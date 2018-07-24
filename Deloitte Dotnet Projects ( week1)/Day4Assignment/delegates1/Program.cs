using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates1
{
    class Program


    {

        public delegate void Num(int m);
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            NumericalFormats n = new NumericalFormats();
            Num nm = n.PrintNumber;
            nm += n.PrintMoney;
            nm += n.PrintHexadecimal;
            nm(number);
        }
    }
}
