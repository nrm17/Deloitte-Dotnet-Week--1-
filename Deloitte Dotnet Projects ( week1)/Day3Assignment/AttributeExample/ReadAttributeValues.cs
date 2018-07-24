using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    class ReadAttributeValues
    {
        public void ReadAttribute(Type t)
        {
           DevInfo di = (DevInfo)Attribute.GetCustomAttribute(t, typeof(DevInfo));

            if (di == null)
                Console.WriteLine("No attribute used");
            else
                Console.WriteLine(di.EmpId + " " + di.Name + " " + di.ProjName + " " + di.DateOfCreation + " " + di.Message);
        }
    }
}
