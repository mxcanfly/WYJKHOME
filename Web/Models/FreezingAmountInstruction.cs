namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FreezingAmountInstruction")]
    public partial class FreezingAmountInstruction
    {
        [Key]
        public string FreezingAmountNote { get; set; }
    }
}
