using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Xero.Api.Infrastructure.Http {
    public class ApiCallEventArgs : EventArgs {
        static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ApiCallEventArgs));

        private const string PATTERN = @"\/api\.xro\/\d.\d\/(?<endpoint>\w+)\/?(?<id>([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12})?\/?(?<att>Attachments)?\/?(?<attachId>.+)?";
        private static readonly Regex ENDPOINT_PARSER = new Regex(PATTERN, RegexOptions.Compiled);
        #region examples
        // /api.xro/2.0/Invoices/B3F2A8BB-3E9B-4BF5-8A0A-9AA43C0DC42A/Attachments/B3F2A8BB-3E9B-4BF5-8A0A-9AA43C0DC42A
        // /api.xro/2.0/Invoices/B3F2A8BB-3E9B-4BF5-8A0A-9AA43C0DC42A/Attachments
        // /api.xro/2.0/CreditNotes/B3F2A8BB-3E9B-4BF5-8A0A-9AA43C0DC42A/Attachments/B3F2A8BB-3E9B-4BF5-8A0A-9AA43C0DC42A
        // /api.xro/2.0/CreditNotes
        // /api.xro/2.0/Organisation
        // /api.xro/2.0/PurchaseOrders
        // /api.xro/2.0/PurchaseOrders/f665acaf-6bc5-4329-a19f-7a8b76b44caf/Attachments/0049213465_20161017.pdf
        #endregion

        public ApiCallEventArgs(string _endpoint, string _method, long _durationMS, string _responseStatusCode, string _errorMessage) {
            this.Endpoint = _endpoint;
            try {
                var endpointMatch = ENDPOINT_PARSER.Match(this.Endpoint);
                if (endpointMatch.Success) {
                    var sb = new StringBuilder(endpointMatch.Groups["endpoint"].Value);
                    if (endpointMatch.Groups["att"].Success) {
                        sb.Append("/GUID/").Append(endpointMatch.Groups["att"].Value);
                    }
                    if (endpointMatch.Groups["attachId"].Success) {
                        sb.Append("/GUID");
                    }
                    this.Endpoint = sb.ToString();
                }
            }
            catch (Exception ex) {
                logger.Error($"Unexpected exception while parsing Xero endpoint: {_endpoint}", ex);
            }
            this.Method = _method;
            this.DurationMS = _durationMS;
            this.ResponseStatusCode = _responseStatusCode;
            this.ErrorMessage = _errorMessage;
        }
        public string Endpoint { get; set; }
        public string Method { get; set; }
        public long DurationMS { get; set; }
        public string ResponseStatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}