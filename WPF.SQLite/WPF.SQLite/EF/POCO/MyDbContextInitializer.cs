using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace WPF.SQLite.EF.POCO
{
    public class MyDbContextInitializer : SqliteCreateDatabaseIfNotExists<MyDbContext>
    {
        public MyDbContextInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {

        }
         
        protected override void Seed(MyDbContext context)
        {
            //context.Set<Team>().Add(new Team
            //{
            //    Name = "YB",
            //});
        }

    }
}
