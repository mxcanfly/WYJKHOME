namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanSubject")]
    public partial class LoanSubject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanSubject()
        {
            LoanAnswer = new HashSet<LoanAnswer>();
        }

        [Key]
        public int SubjectID { get; set; }

        [Required]
        [StringLength(128)]
        public string Subject { get; set; }

        public int Sort { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanAnswer> LoanAnswer { get; set; }
    }
}
