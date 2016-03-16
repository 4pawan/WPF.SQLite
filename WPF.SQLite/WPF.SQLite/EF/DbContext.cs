using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace WPF.SQLite.EF
{
        public class MyDbContext : DbContext
        {
            public MyDbContext()
                : base("ConnectionStringName")
            { }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
                Database.SetInitializer(sqliteConnectionInitializer);
            }
        }
   
}
