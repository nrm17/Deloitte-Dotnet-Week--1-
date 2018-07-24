using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NewFeatures
{
    partial class Employee
    {
        public void ShowData()
        {
            Console.WriteLine(" Id : " + id);
            Console.WriteLine(" Name : " + name);
            Console.WriteLine(" Dept : " + dept);
            Console.WriteLine(" salary : " + salary);

        }
    }
}
