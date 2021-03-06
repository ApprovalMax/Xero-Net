﻿using System;
using System.Net;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;
using HttpUtility = Xero.Api.Infrastructure.ThirdParty.HttpUtility.HttpUtility;

namespace Xero.Api.Infrastructure.OAuth
{
    public class OAuthTokens
    {
        private readonly string _authorizeUri;
        private readonly string _tokenUri;
        private const string XeroRequestUri = "oauth/RequestToken";
        private const string XeroAccessTokenUri = "oauth/AccessToken";
        private const string XeroAuthorizeUri = "oauth/Authorize";

        public event EventHandler<ApiCallEventArgs> ApiCalled;

        public OAuthTokens(string authorizeUri, string tokenUri)
        {
            _authorizeUri = authorizeUri;
            _tokenUri = tokenUri;
        }

        public string AuthorizeUri
        {
            get
            {
                var uri = new UriBuilder(_authorizeUri)
                {
                    Path = XeroAuthorizeUri
                };

                return uri.ToString();
            }
        }

        public string RequestUri
        {
            get
            {
                return XeroRequestUri;
            }
        }

        public string AccessUri
        {
            get
            {
                return XeroAccessTokenUri;
            }
        }

        public IToken GetRequestToken(IConsumer consumer, string header)
        {
            return GetToken(_tokenUri, new Token { ConsumerKey = consumer.ConsumerKey, ConsumerSecret = consumer.ConsumerSecret }, XeroRequestUri, header);
        }

        public IToken GetAccessToken(IToken token, string header)
        {
            return GetToken(_tokenUri, token, XeroAccessTokenUri, header);
        }

        public IToken RenewAccessToken(IToken token, string header)
        {
            return GetToken(_tokenUri, token, XeroAccessTokenUri, header);
        }

        public IToken GetToken(string baseUri, IToken consumer, string endPoint, string header)
        {
            var req = new HttpClient(baseUri)
            {
                UserAgent = "Xero Api wrapper - " + consumer.ConsumerKey
            };

            EventHandler<ApiCallEventArgs> apiCalledHandler = (sender, e) => ApiCalled?.Invoke(this, e);
            req.ApiCalled += apiCalledHandler;

            req.AddHeader("Authorization", header);

            var response = req.Post(endPoint, string.Empty);

            req.ApiCalled -= apiCalledHandler;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (response.Body.Contains("oauth_problem"))
                {
                    throw new OAuthException(response.Body);
                }

                throw new UnexpectedOauthResponseException(response.StatusCode, response.Body);
            }

            var qs = HttpUtility.ParseQueryString(response.Body);
            var expires = qs["oauth_expires_in"];
            var session = qs["oauth_session_handle"];

            var token = new Token(consumer.ConsumerKey, consumer.ConsumerSecret)
            {
                TokenKey = qs["oauth_token"],
                TokenSecret = qs["oauth_token_secret"],
                OrganisationId = qs["xero_org_muid"]
            };

            if (!string.IsNullOrWhiteSpace(expires))
            {
                token.ExpiresAt = DateTime.UtcNow.AddSeconds(int.Parse(expires));
            }

            if (!string.IsNullOrWhiteSpace(session))
            {
                token.Session = session;
                token.SessionExpiresAt = DateTime.UtcNow.AddSeconds(int.Parse(qs["oauth_authorization_expires_in"]));
            }

            return token;
        }
    }
}
