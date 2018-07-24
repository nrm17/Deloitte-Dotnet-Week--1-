using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.ShowData();


            //Employee em = new Employee(111, " king", " IMA", 4333);
            //em.ShowData();

            //for (int i = 0; i < 10; i++)
            //{
            //    Counter.CountData();
            //}

            int Num1 = 100;
            int Num2 = 200;

            string str1 = "Hello";
            string str2 = " World";

            Console.WriteLine("Before swapping :  " + Num1 + " " + Num2);
            SwapExample<int> intObj = new SwapExample<int>();
            intObj.Swap(ref Num1, ref Num2);
            Console.WriteLine("after swapping :  " + Num1 + " " + Num2);

            Console.WriteLine("Before swapping :  " + str1 + " " + str2);
            SwapExample<string> strObj = new SwapExample<string>();
            strObj.Swap(ref str1, ref str2);
            Console.WriteLine("after swapping :  " + str1 + " " + str2);

            int? age = 32;
            double? pi = null;

            if (pi.HasValue)
                Console.WriteLine(pi.Value);
            else
                Console.WriteLine(" Age : NULL");
                
           

        }
    }
}
