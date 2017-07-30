using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECoachingWebAPI.Models
{
    public class Context : DbContext
    {
        public Context(): base("Context") 
        {
            Database.SetInitializer<Context>(new ContextDBInitializer());
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
    }

    public class ContextDBInitializer : DropCreateDatabaseAlways<Context>
    {
        List<Country> countries = new List<Country>();

        public ContextDBInitializer()
        {
            countries.Add(new Country { CountryName = "Argentina" });
            countries.Add(new Country { CountryName = "Brasil" });

            countries[0].States = new List<State>();
            countries[0].States.Add(new State { StateName = "Buenos Aires" });
            countries[0].States.Add(new State { StateName = "Santa Fe" });
            countries[0].States.Add(new State { StateName = "Tucuman" });

            countries[1].States = new List<State>();
            countries[1].States.Add(new State { StateName = "Sao Paulo" });
            countries[1].States.Add(new State { StateName = "Rio de Janeiro" });
            countries[1].States.Add(new State { StateName = "Minas Gerais" });
            countries[1].States.Add(new State { StateName = "Pernambuco" });
        }

        protected override void Seed(Context context)
        {
            foreach (Country p in countries)
            {
                context.Country.Add(p);

                foreach (State s in p.States)
                {
                    context.State.Add(s);
                }
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}