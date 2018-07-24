using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(12, 13));
            Console.WriteLine(c.Sub(12, 12));

            Console.WriteLine(c.Mul(12, 13));
        }
    }
}
