using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value 1");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value 2");
            int v2 = int.Parse(Console.ReadLine());


            UserTrail uT = new UserTrail();

            try
            {
                uT.show(v1, v2);
                uT.calculate(v1, v2);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
