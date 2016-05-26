namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseAudit")]
    public partial class BaseAudit
    {
        public int ID { get; set; }

        public int SocialSecurityPeopleID { get; set; }

        public decimal CurrentBase { get; set; }

        public decimal BaseAdjusted { get; set; }

        public DateTime ApplyDate { get; set; }

        public DateTime? AuditDate { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }
    }
}
