namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnterpriseSocialSecurity")]
    public partial class EnterpriseSocialSecurity
    {
        [Key]
        public int EnterpriseID { get; set; }

        [StringLength(50)]
        public string EnterpriseName { get; set; }

        [StringLength(50)]
        public string EnterpriseArea { get; set; }

        [StringLength(50)]
        public string ContactUser { get; set; }

        [StringLength(50)]
        public string ContactTel { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string OfficeTel { get; set; }

        [StringLength(50)]
        public string HouseholdProperty { get; set; }

        public string OrgAddress { get; set; }

        public decimal? SocialAvgSalary { get; set; }

        public decimal? MinSocial { get; set; }

        public decimal? MaxSocial { get; set; }

        public decimal? CompYangLao { get; set; }

        public decimal? CompYiLiao { get; set; }

        public decimal? CompShiYe { get; set; }

        public decimal? CompGongShang { get; set; }

        public decimal? CompShengYu { get; set; }

        public decimal? PersonalYangLao { get; set; }

        public decimal? PersonalYiLiao { get; set; }

        public decimal? PersonalShiYeTown { get; set; }

        public decimal? PersonalShiYeRural { get; set; }

        public decimal? PersonalGongShang { get; set; }

        public decimal? PersonalShengYu { get; set; }

        public decimal? MinAccumulationFund { get; set; }

        public decimal? MaxAccumulationFund { get; set; }

        public decimal? CompProportion { get; set; }

        public decimal? PersonalProportion { get; set; }

        public bool? IsDefault { get; set; }
    }
}
