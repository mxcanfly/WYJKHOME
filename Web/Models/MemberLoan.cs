namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberLoan")]
    public partial class MemberLoan
    {
        public int ID { get; set; }

        public int MemberID { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal AlreadyUsedAmount { get; set; }

        public decimal AvailableAmount { get; set; }
    }
}
