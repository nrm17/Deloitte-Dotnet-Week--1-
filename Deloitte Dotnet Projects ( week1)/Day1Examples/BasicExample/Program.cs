using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime doj;

            Console.WriteLine("Enter the id ");
//d = int.Parse(Console.ReadLine()); // parse function is usd to conver tstring to different datatypes, all input in c# is treated as string 
            bool res = int.TryParse(Console.ReadLine(), out id);
            if(res==false)
            {
                Console.WriteLine("Id has to be integer values only ");
                return;
            }
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the gender");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the salary ");
            salary = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter if cab is required");
            cab = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of joining");
            doj = DateTime.Parse(Console.ReadLine());


            Console.WriteLine(" ID : " + id);
            Console.WriteLine(" Name : " + name);
            Console.WriteLine(" Gender : " + gender);
            Console.WriteLine(" Salary : " + salary);
            Console.WriteLine("Cab : " + cab);
            Console.WriteLine(" DOJ : " + doj);


        }
    }
}
