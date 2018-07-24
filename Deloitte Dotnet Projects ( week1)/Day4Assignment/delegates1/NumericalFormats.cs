using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates1
{
    class NumericalFormats
    {
        int intvalue;
        decimal decimalvalue;
        int evalue;

        public void PrintNumber(int  number)
        {
            intvalue = number;
            Console.WriteLine("Value : " + intvalue.ToString("N1", CultureInfo.InvariantCulture));
        }
        public void PrintMoney(int number)
        {
           decimalvalue = number;
            Console.WriteLine("Given Amount : " + decimalvalue.ToString("C", CultureInfo.InvariantCulture));
        }
        public void PrintHexadecimal(int number)
        {
            evalue = number;
            Console.WriteLine("Hex : " + evalue.ToString("X"));
        }
    }
}
