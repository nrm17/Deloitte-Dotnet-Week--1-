using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EmployeeLibrary;


namespace ReflectionExampless
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assembly t = Assembly.Load("EmployeeLibrary"); // returns na assembly object // not needed 

            Type tt = typeof(Employee); // all the details of the class is stored in tt

            ConstructorInfo[] ci = tt.GetConstructors();
            foreach (var c in ci)
            {
                Console.WriteLine("Constructor : " + c.Name);
                Console.WriteLine("Is public :  " + ci);


                ParameterInfo[] pi = c.GetParameters();
                foreach (var p in pi)
                {
                    Console.WriteLine("Paramter type : " + p.ParameterType);
                    Console.WriteLine("Parameter position : " + p.ParameterType);
                    Console.WriteLine("Default value+ : " + p.DefaultValue);


                 }
        }

            MethodInfo[] mi = tt.GetMethods();
            foreach (var m in mi)
            {
                Console.WriteLine("Method Name : " + m.Name);
                Console.WriteLine("Moduke name : " + m.Module);
                Console.WriteLine("Method Name : " + m.ReturnType);
                Console.WriteLine("IsPublic : " + m.IsPublic);

            }

            Console.WriteLine("**************************************");

            MemberInfo[] fi = tt.GetMembers();
            foreach (var f in fi)
            {
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Module);
                Console.WriteLine(f.DeclaringType);
                Console.WriteLine(f.MemberType);
                Console.WriteLine("**************************************");

            }


        }
}}
