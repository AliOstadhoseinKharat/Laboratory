namespace DomainModel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LabotatoryContext2 : DbContext
    {
        public LabotatoryContext2()
            : base("name=LabotatoryContext2")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<InsuranceType> InsuranceTypes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientHeader> PatientHeaders { get; set; }
        public virtual DbSet<PatientTestDetail> PatientTestDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TestCategory> TestCategories { get; set; }
        public virtual DbSet<TestRanx> TestRanges { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PatientHeaders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.PatientHeaders)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PatientHeader>()
                .HasMany(e => e.PatientTestDetails)
                .WithRequired(e => e.PatientHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TestCategory>()
                .HasMany(e => e.Tests)
                .WithOptional(e => e.TestCategory)
                .HasForeignKey(e => e.TestCategoryID);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.PatientTestDetails)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.TestRanges)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);
        }
    }
}
