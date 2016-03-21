using System.Collections.Generic;
using System.Data.Entity;
using SQLite.CodeFirst;
using WPF.SQLite.EF.Entity;

namespace WPF.SQLite.EF.PerfectSmile
{
    public class PatientDbInitializer : SqliteDropCreateDatabaseAlways<PatientDbContext>
    {
        public PatientDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {
        }

        protected override void Seed(PatientDbContext context)
        {
            context.Set<User>().Add(new User
            {
                Name = "pk",
                Password = "pk"
            });

            context.Set<User>().Add(new User
            {
                Name = "sy",
                Password = "sy"
            });

        }



    }
}