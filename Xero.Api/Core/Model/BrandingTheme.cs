using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class BrandingTheme : CoreData, IHasId
    {
        [DataMember(Name = "BrandingThemeID")]
        public Guid BrandingThemeId { get; set; }

        [DataMember(Name = "CreatedDateUTC")]
        public DateTime CreatedDateUtc { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int SortOrder { get; set; }

        public Guid Id {
            get { return this.BrandingThemeId; }
            set { this.BrandingThemeId = value; }
        }
    }
}