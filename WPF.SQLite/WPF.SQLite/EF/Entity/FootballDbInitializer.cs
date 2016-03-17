using System.Collections.Generic;
using System.Data.Entity;
using SQLite.CodeFirst;

namespace WPF.SQLite.EF.Entity
{
    public class FootballDbInitializer : SqliteDropCreateDatabaseAlways<FootballDbContext>
    {
        public FootballDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        { }

        protected override void Seed(FootballDbContext context)
        {
            context.Set<Team>().Add(new Team
            {
                Name = "YB",
                Coach = new Coach
                {
                    City = "Zürich",
                    FirstName = "Masssaman",
                    LastName = "Nachn",
                    Street = "Testingstreet 844"
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        City = "Bern",
                        FirstName = "Marco",
                        LastName = "Bürki",
                        Street = "Wunderstrasse 43",
                        Number = 12
                    },
                    new Player
                    {
                        City = "Berlin",
                        FirstName = "Alain",
                        LastName = "Rochat",
                        Street = "Wonderstreet 13",
                        Number = 14
                    }
                },
                Stadion = new Stadion
                {
                    Name = "Stade de Suisse",
                    City = "Bern",
                    Street = "Papiermühlestrasse 71"
                }
            });
        }
    }
}