namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostParameterSetting")]
    public partial class CostParameterSetting
    {
        public int ID { get; set; }

        public decimal? BacklogCost { get; set; }

        public decimal? FreezingAmount { get; set; }

        public decimal? PayBeforeServiceCost { get; set; }

        [StringLength(512)]
        public string RenewServiceCost { get; set; }

        public int? Status { get; set; }
    }
}
