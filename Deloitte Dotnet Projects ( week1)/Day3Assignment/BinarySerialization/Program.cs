using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonInfo pi = new PersonInfo("Clark", 53);
            SerializeData sd = new SerializeData();
            //sd.SaveData(pi);

            PersonInfo pi = new PersonInfo();
            pi.ShowData();
            pi = sd.GetData();
            pi.ShowData();
        }
    }
}
