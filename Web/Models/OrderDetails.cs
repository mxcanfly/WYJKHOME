namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        public int? SocialSecurityPeopleID { get; set; }

        [StringLength(50)]
        public string SocialSecurityPeopleName { get; set; }

        public decimal? SocialSecurityAmount { get; set; }

        public int? SocialSecuritypayMonth { get; set; }

        public decimal? SocialSecurityServiceCost { get; set; }

        public decimal? SocialSecurityFirstBacklogCost { get; set; }

        public decimal? SocialSecurityBuCha { get; set; }

        public decimal? AccumulationFundAmount { get; set; }

        public int? AccumulationFundpayMonth { get; set; }

        public decimal? AccumulationFundServiceCost { get; set; }

        public decimal? AccumulationFundFirstBacklogCost { get; set; }

        public virtual Order Order { get; set; }
    }
}
