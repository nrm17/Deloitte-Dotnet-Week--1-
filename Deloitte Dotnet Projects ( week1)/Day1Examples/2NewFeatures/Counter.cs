using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NewFeatures
{
      static class Counter
    {

        static int count;
        static Counter ()
        {
            count = 11;
        }

        public static void CountData()
        {
            // static method can have local non static variable
            int ctr = 0;
            ctr++;
            count++;

            Console.WriteLine(" ctr :  " + ctr);
            Console.WriteLine("count :  " + count);

        }
    }
}
