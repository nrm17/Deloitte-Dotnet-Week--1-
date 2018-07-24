using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class PersonInfo
    {
        string name;
        int age;
        string email;

        public void GetData()
        {
            Console.WriteLine(" enter the name ");
            name = Console.ReadLine();
            Console.WriteLine("enter the age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the email");
            email = Console.ReadLine();
        }

        public void ShowData()
        {
            Console.WriteLine(" Name  : " + name);
            Console.WriteLine(" age  : " + age);
            Console.WriteLine(" Email : " + email);
        }

        public PersonInfo()
        {
            // clr number = 0, string/char = null
            name = "default";
            age = 99;
            email = "efault@default.com";
        }
        public PersonInfo( string name , int age , string em)
        {
            // paramter variables are local variables
            this.name = name;
            this.age = age;
            email = em;

            
        }

        ~ PersonInfo()
        {
            GC.Collect();
            Console.WriteLine("Object destroyed ");

        }


    }
}
