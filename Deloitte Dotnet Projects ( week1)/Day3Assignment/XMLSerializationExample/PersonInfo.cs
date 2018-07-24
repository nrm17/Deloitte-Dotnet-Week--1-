using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace XMLSerializationExample
{
    [Serializable]
    [XmlRoot]
    public  class PersonInfo
    {   [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public int  Age { get; set; }

        public PersonInfo(string n , int a)
        {
            Name = n;
            Age = a;

        }

        public void ShowData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("aGE : " + Age);
        }
        public PersonInfo()
        {

        }
    }
}
