using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonInfo pi = new PersonInfo("Martin", 22);
            Serialize s = new Serialize();
            // s.SaveData(pi);

            PersonInfo pnew = new PersonInfo();
            pnew.ShowData();
            pnew = s.GetData();
            pnew.ShowData();
        }
    }
}
