namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccumulationFund")]
    public partial class AccumulationFund
    {
        public int AccumulationFundID { get; set; }

        public int? SocialSecurityPeopleID { get; set; }

        [StringLength(50)]
        public string AccumulationFundArea { get; set; }

        public decimal? AccumulationFundBase { get; set; }

        public decimal? PayProportion { get; set; }

        public DateTime? PayTime { get; set; }

        public int? PayMonthCount { get; set; }

        public int? AlreadyPayMonthCount { get; set; }

        public int? PayBeforeMonthCount { get; set; }

        [StringLength(512)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? RelationEnterprise { get; set; }

        public int? PayedMonthCount { get; set; }

        [StringLength(50)]
        public string StopMethod { get; set; }

        public DateTime? ApplyStopDate { get; set; }

        public DateTime? StopDate { get; set; }

        [StringLength(50)]
        public string AccumulationFundNo { get; set; }

        public string AccumulationFundException { get; set; }

        public DateTime? HandleDate { get; set; }
    }
}
