using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDetail p1 = new PizzaDetail { PizzaID = 1, PizzaName = "farmhouse", Toppings = "Sweetcorn , onion,Tomato", Type = " Veg", Size = "L", Price = 450 };
            PizzaDetail p2 = new PizzaDetail { PizzaID = 1, PizzaName = "farmhouse", Toppings = "Sweetcorn , onion,Tomato", Type = " Veg", Size = "L", Price = 450 };
            PizzaDetail p3 = new PizzaDetail { PizzaID = 1, PizzaName = "farmhouse", Toppings = "Sweetcorn , onion,Tomato", Type = " Veg", Size = "L", Price = 450 };
            PizzaDetail p4 = new PizzaDetail { PizzaID = 1, PizzaName = "farmhouse", Toppings = "Sweetcorn , onion,Tomato", Type = " Veg", Size = "L", Price = 450 };

            PizzaDBEntities db = new PizzaDBEntities();
            db.PizzaDetails.Add(p1);
            db.PizzaDetails.Add(p2);

            var res = db.SaveChanges();

            if (res > 0)
                Console.WriteLine("Data inserted");
            
        }
    }
}
