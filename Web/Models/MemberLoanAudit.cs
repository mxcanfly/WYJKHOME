namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberLoanAudit")]
    public partial class MemberLoanAudit
    {
        public int ID { get; set; }

        public int MemberID { get; set; }

        public decimal ApplyAmount { get; set; }

        [Required]
        [StringLength(10)]
        public string LoanTerm { get; set; }

        [Required]
        [StringLength(10)]
        public string LoanMethod { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        public DateTime ApplyDate { get; set; }

        public DateTime? AuditDate { get; set; }
    }
}
