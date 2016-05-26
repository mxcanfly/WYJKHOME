namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountRecord")]
    public partial class AccountRecord
    {
        public int ID { get; set; }

        public int? MemberID { get; set; }

        public int? SocialSecurityPeopleID { get; set; }

        [StringLength(50)]
        public string SocialSecurityPeopleName { get; set; }

        [StringLength(50)]
        public string ShouZhiType { get; set; }

        [StringLength(50)]
        public string LaiYuan { get; set; }

        [StringLength(50)]
        public string OperationType { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Balance { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
