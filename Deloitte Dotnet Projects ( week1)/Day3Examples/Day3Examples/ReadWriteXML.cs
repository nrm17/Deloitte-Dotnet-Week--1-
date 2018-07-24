using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Day3Examples
{
    class ReadWriteXML
    {
        List<PartsInfo> pList = new List<PartsInfo>();


        public ReadWriteXML()
        {
            pList.Add(new PartsInfo { Item = "Motherboard", Manufacturer = "Asus", Model = "P3B-F", Cost = 123 });

            pList.Add( new PartsInfo { Item = "rboard", Manufacturer = "Asus", Model = "P3B-F", Cost = 1223 });

            pList.Add(new PartsInfo { Item = "Mother", Manufacturer = "sus", Model = "P3B-F", Cost = 1203 });

            pList.Add(new PartsInfo { Item = "Motherboar", Manufacturer = "sus", Model = "P3B-F", Cost = 123 });

        }

        public void WriteXml()
        {
            XmlWriter w = XmlWriter.Create(@"c:\\Files\PartsInfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("PARTS");
           
            foreach (var p in pList)
            {
                w.WriteStartElement("PART");
                w.WriteElementString("Item", p.Item);
                w.WriteElementString("Manufacturer", p.Manufacturer);
                w.WriteElementString("Model", p.Model);
                w.WriteElementString("Cost", p.Cost.ToString());
                w.WriteEndElement(); // closes part
            }

            
            w.WriteEndElement(); // closes parts
            w.Close();
            Console.WriteLine("XML created");

        }

        public void ReadXml()
        {
            XElement xe = XElement.Load(@"c:\Files\PartsInfo.xml");

            var data = xe.Elements();

            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("*********************");
            // Diplays all data eith price > 150

            var data1 = from t in xe.Elements("PART")
                        where (int)t.Element("Cost") > 150
                        select t;

            foreach (var d in data1)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("*********************");

            foreach (var d in data)
            {
                Console.WriteLine(d.Element("Item").Value + " " + d.Element("Cost").Value);

            }



        }

    }
    }

