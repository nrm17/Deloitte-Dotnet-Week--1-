using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string a = Console.ReadLine();

            try
            {
                if (a == "Deloitte Training")
                {

                }
                else
                {
                    throw (new NoMatchException("No match"));
                }

            }
            catch (NoMatchException nme)
            {
                Console.WriteLine(nme.Message);
                
            }
        }
    }
}
