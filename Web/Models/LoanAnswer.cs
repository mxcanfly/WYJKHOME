namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanAnswer")]
    public partial class LoanAnswer
    {
        [Key]
        [Column(Order = 0)]
        public int AnswerID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Answer { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal LoanAmount { get; set; }

        public int? SubjectID { get; set; }

        public virtual LoanSubject LoanSubject { get; set; }
    }
}
