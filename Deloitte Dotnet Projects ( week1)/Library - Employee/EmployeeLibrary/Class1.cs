using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {

        int empid;
        string Name;

        public int Empid
        {
            get
            {
                return empid;
            }

            set
            {
                empid = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }

           
        }


        public Employee()
        { }

        public Employee( string name , int id)
        {
            Name = name;
            empid = id;
        }

        public void ShowData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID : " + empid);

        }
    }
}
