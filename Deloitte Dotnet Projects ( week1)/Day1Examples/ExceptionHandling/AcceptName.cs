using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class AcceptName
    {
        public void InputName()
        {
            Console.WriteLine("eNTER NAME IN blocK LETTERS");
            string name = Console.ReadLine();

            char[] ch = name.ToCharArray();
            
            foreach(char c in ch)
            {
                if(!char.IsUpper(c))
                {
                    throw new UpperCaseException();
                }
            }

            Console.WriteLine("Name entered is valid and it is  " + name);
        }
    }
}
