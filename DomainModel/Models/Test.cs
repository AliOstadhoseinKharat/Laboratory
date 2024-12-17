namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            PatientTestDetails = new HashSet<PatientTestDetail>();
            TestRanges = new HashSet<TestRanx>();
        }

        public int TestID { get; set; }

        [Required]
        [StringLength(150)]
        public string TestName { get; set; }

        public int UnitID { get; set; }

        public bool AgeHasEffect { get; set; }

        public bool GenderHasEffect { get; set; }

        public int? TestCategoryID { get; set; }

        public long? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientTestDetail> PatientTestDetails { get; set; }

        public virtual TestCategory TestCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestRanx> TestRanges { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
