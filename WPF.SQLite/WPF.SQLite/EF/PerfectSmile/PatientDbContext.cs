using System.Data.Entity;
using WPF.SQLite.EF.Entity;

namespace WPF.SQLite.EF.PerfectSmile
{
    public class PatientDbContext : DbContext
    {

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientHistory> PatientHistories { get; set; }
        public virtual DbSet<User> Users { get; set; }



        public PatientDbContext()
            : base("patientDbCF")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PatientHistory>()
                .Property(e => e.TreatmentDone)
                .IsUnicode(false);

            modelBuilder.Entity<PatientHistory>()
                .Property(e => e.PaymentDone)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PatientHistory>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PatientHistory>()
                .Property(e => e.AdditionalComment)
                .IsUnicode(false);

            modelBuilder.Entity<PatientHistory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            var initializer = new PatientDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }
}
