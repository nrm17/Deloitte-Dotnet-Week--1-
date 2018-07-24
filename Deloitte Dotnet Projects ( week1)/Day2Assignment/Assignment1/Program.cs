using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder
                { OrderID = r.Next(10,500) , OrderDate = DateTime.Now , PizzaType = "Veg" , PizzaSize = 'M' , Toppings = "Sweet Corn" ,Price = 500 , Qty = 200



                },

                new PizzaOrder
                { OrderID = r.Next(10,500)  , OrderDate = DateTime.Now , PizzaType = "Non Veg" , PizzaSize = 'L' , Toppings = "Chicken" ,Price = 1500 , Qty = 3},

                new PizzaOrder
                { OrderID = r.Next(10,500) , OrderDate = DateTime.Now , PizzaType = "Non Veg" , PizzaSize = 'M' , Toppings = "Egg" ,Price = 8000 , Qty = 2 },

                new PizzaOrder
                { OrderID = r.Next(10,500)  , OrderDate = DateTime.Now , PizzaType = "Veg" , PizzaSize = 'S' , Toppings = "Onion" ,Price = 2000 , Qty = 1 }
            };

            // a) display all piza ordered 

            foreach (var a in po)

            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Price + " " + a.Qty);
            }

            Console.WriteLine(" ------------------------------------------------------------");

            // b) display pizza based on pizza type and pizza size

            var b = po.OrderByDescending(x => x.PizzaSize).OrderByDescending(y => y.PizzaType).Select(z => new { PizS = z.PizzaSize, PizT = z.PizzaType });

            foreach (var b1 in b)
            {
                Console.WriteLine(b1.PizS + " " + b1.PizT);
            }

            Console.WriteLine(" ------------------------------------------------------------");

            // c) Display Count of Pizza Sold, Amount Collected group by PizzaType

            var c = po.GroupBy(x => x.PizzaType).Select(x => new { PT = x.Key, CT = x.Sum(z => z.Qty), AT = x.Sum(y => y.Price) });
            {

                foreach (var c1 in c)

                {
                    Console.WriteLine(c1.PT + " " + c1.CT + " " + c1.AT);
                }
            }
            Console.WriteLine(" ------------------------------------------------------------");

            // d) Display Count of Pizza Sold, Amount Collected group by PizzaType

            var d = po.GroupBy(x => x.PizzaSize).Select(x => new { PT = x.Key, CT = x.Sum(z => z.Qty), AT = x.Sum(y => y.Price) });
            {

                foreach (var d1 in d)

                {
                    Console.WriteLine(d1.PT + " " + d1.CT + " " + d1.AT);
                }
            }
            Console.WriteLine(" ------------------------------------------------------------");

            //e) Display only Pizza Type and toppings where PizzaSize="M"

            var e = po.Where(x => x.PizzaSize == 'M').Select(y => new { PT = y.PizzaType, T = y.Toppings });
            {
                foreach (var e1 in e)
                {
                    Console.WriteLine(e1.PT + " " + e1.T);
                }
                Console.WriteLine(" ------------------------------------------------------------");
            }

            // f) Display the Pizza Details which has the Max Price

            var f = po.Where(x => x.Price*x.Qty == po.Max(y => (y.Price*y.Qty)));
            {
                foreach (var f1 in f)
                {

                    Console.WriteLine(f1.OrderID + " " + f1.OrderDate + " " + f1.PizzaType + " " + f1.PizzaSize + " " + f1.Toppings + " " + f1.Price + " " + f1.Qty + " " + f1.Price * f1.Qty);

                }
            }

            Console.WriteLine(" ------------------------------------------------------------");

            // Display the Pizza Details which has the Min Price

            var g = po.Where(x => x.Price*x.Qty == po.Min(y => (y.Price*y.Qty)));
            {
                foreach (var g1 in g)
                {
                    Console.WriteLine(g1.OrderID + " " + g1.OrderDate + " " + g1.PizzaType + " " + g1.PizzaSize + " " + g1.Toppings + " " + g1.Price + " " + g1.Qty + " " + g1.Price*g1.Qty);

                }
            }
            Console.WriteLine(" ------------------------------------------------------------");
        }
    }
}
