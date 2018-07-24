using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerializationExample
{
    class Serialize
    {
        FileStream fs = null;
        public void SaveData(PersonInfo pi)
        {

            try
            {
                fs = new FileStream(@"c:\Files\PersonInfo.xml", FileMode.Create, FileAccess.Write);

                XmlSerializer xs = new XmlSerializer(typeof(PersonInfo));
                xs.Serialize(fs, pi);
                Console.WriteLine("Data serialized");
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                fs.Close();
            }
        }

        public PersonInfo GetData()
        {
            PersonInfo pi = null;
            try
            {
                fs = new FileStream(@"c:\Files\PersonInfo.xml", FileMode.Open, FileAccess.Read);

                XmlSerializer xs = new XmlSerializer(typeof(PersonInfo));
             
                pi = (PersonInfo)xs.Deserialize(fs);
                Console.WriteLine("Data deserialized");
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                fs.Close();
            }

            return pi;
        }
    }
}
