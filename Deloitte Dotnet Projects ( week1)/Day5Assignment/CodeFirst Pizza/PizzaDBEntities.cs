using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst_Pizza
{
    class PizzaDBEntities : DbContext
    {
        public DbSet<PizzaDetail> PizzaDetails { get; set; }

        public PizzaDBEntities() : base("MyDB")
        {

        }
    }
}
