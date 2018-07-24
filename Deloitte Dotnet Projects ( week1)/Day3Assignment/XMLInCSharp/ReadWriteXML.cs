using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLInCSharp
{
    class ReadWriteXML
    {
        List<BookInfo> bookList = new List<BookInfo>();

        public ReadWriteXML()
        {
            bookList.Add(new BookInfo { BookID = 123, Title = "hARRY POTTER", Category = "cHILDREN", Price = 250 });

            bookList.Add(new BookInfo { BookID = 124, Title = "HAIRY POTTER", Category = "ADULT", Price = 450 });

            bookList.Add(new BookInfo { BookID = 125, Title = "hARRY POT", Category = "DOPE", Price = 650 });

            
        }

        public void WriteXML()
        {
            XmlWriter w = XmlWriter.Create(@"c:\Files\BookInfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("BookInfo");

            foreach (var b in bookList)
            {
                w.WriteStartElement("Books");
                w.WriteAttributeString("BookID", b.BookID.ToString());


                w.WriteStartElement("Description");
                w.WriteElementString("Title", b.Title);
                w.WriteElementString("Category", b.Category);
                w.WriteEndElement(); // closes description

                w.WriteElementString("Price", b.Price.ToString());

                w.WriteEndElement(); // closes books




            }

            w.WriteEndElement(); // closes book info
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("XML Created");


                  }

        public void ReadXML()
        {
            XElement xe = XElement.Load("c:\\Files\\BookInfo.xml");
            var data = xe.Elements();

            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            // read element data
           
            foreach (var d in data)
            {
                Console.WriteLine(d.Element("Description").Element("Title").Value + " " + d.Element("Price").Value);
            }

            var data2 = from t in xe.Elements("Books")
                        where (int)t.Element("Price") > 500
                        select t;

            foreach (var d in data2)
            {
                Console.WriteLine(d);
            }


        }
    }
}
