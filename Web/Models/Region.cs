namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public int RegionId { get; set; }

        [Required]
        [StringLength(50)]
        public string RegionName { get; set; }

        [Required]
        [StringLength(6)]
        public string RegionCode { get; set; }

        [Required]
        [StringLength(6)]
        public string ParentCode { get; set; }

        public int RegionLevel { get; set; }
    }
}
