using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class UserTrail
    {
        int val1, val2;

        public void show(int v1 , int v2)
        {
            if(v1<0)
            {
                throw new Exception("Value is less than zero");

            }
            else { Console.WriteLine("V1 > 0 "); }

            if(v2<0)
            {
                throw new Exception("Value is less than zero");
            }
            else { Console.WriteLine("V2 > 0 "); }

        }

        public void calculate( int v1, int v2)
        {
            if((v1-v2) < 0)
            {
                throw new Exception("the diff is less than zero");
            }
            else { Console.WriteLine("the difference is positive"); }

        }
    }
}
