namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PatientHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientHeader()
        {
            PatientTestDetails = new HashSet<PatientTestDetail>();
        }

        [Key]
        public int PatientTestHeaderID { get; set; }

        public DateTime HeaderDate { get; set; }

        public int PatientID { get; set; }

        public int EmployeeID { get; set; }

        public int? InsuranceTypeID { get; set; }

        [StringLength(100)]
        public string DrName { get; set; }

        public long? TotalPrice { get; set; }

        public int Age { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual InsuranceType InsuranceType { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientTestDetail> PatientTestDetails { get; set; }
    }
}
