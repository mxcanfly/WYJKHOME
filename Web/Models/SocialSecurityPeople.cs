namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialSecurityPeople")]
    public partial class SocialSecurityPeople
    {
        public int SocialSecurityPeopleID { get; set; }

        public int? MemberID { get; set; }

        [StringLength(50)]
        public string SocialSecurityPeopleName { get; set; }

        [StringLength(50)]
        public string IdentityCard { get; set; }

        [StringLength(512)]
        public string IdentityCardPhoto { get; set; }

        [StringLength(512)]
        public string HouseholdProperty { get; set; }

        public bool? IsPaySocialSecurity { get; set; }

        public bool? IsPayAccumulationFund { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? IsPay { get; set; }
    }
}
