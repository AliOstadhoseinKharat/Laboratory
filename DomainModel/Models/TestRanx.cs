namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class TestRanx
    {
        [Key]
        public int RangeID { get; set; }

        public int? FromAge { get; set; }

        public int? ToAge { get; set; }

        public int? Gender { get; set; }

        public double FromValue { get; set; }

        public double ToValue { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int TestID { get; set; }

        public bool? Hazard { get; set; }

        public virtual Test Test { get; set; }
    }
}
