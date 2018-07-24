using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{    

    [Serializable]
    class PersonInfo
    {
        string Name;
        int Age;

        public PersonInfo()
        {

        }
        
        public PersonInfo( string name , int age)
        {
            Name = name;
            Age = age;

        }

        public void ShowData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }
}
