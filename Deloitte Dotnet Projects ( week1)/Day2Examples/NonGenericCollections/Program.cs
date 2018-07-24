using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(12); // BOXING IS HAPPENING :p
            //al.Add("hELLO wORLD");
            //al.Add('C');
            //al.Add(12);   


            //Console.WriteLine("After adding");
            //foreach (object t in al)
            //    Console.WriteLine(t);

            //Console.WriteLine("After inserting");

            //al.Insert(0, "New Data");
            //al.Insert(2, "Another Elements");
            //foreach (object t in al)
            //    Console.WriteLine(t);

            //Console.WriteLine("After removing");
            //al.Remove(12);
            //al.RemoveAt(2);
            //foreach (object t in al)
            //    Console.WriteLine(t);

            //Console.WriteLine("Specific data : " + al[1]);

            //Hashtable ht = new Hashtable();
            //ht.Add("In", "India");
            //ht.Add("US", "aMERICA");
            //ht.Add("UK", "United kingdom");
            ////ht.Add("In", "Bharat");  // Throws run time exception as key has to be unique data

            //IDictionaryEnumerator ide = ht.GetEnumerator();

            //ide = ht.GetEnumerator();

            //while(ide.MoveNext())
            //{
            //    Console.WriteLine(ide.Key + "," + ide.Value);
            //}

            List<string> cities = new List<string>();

            cities.Add("Mysore");
            cities.Add("Mumbai");
            cities.Add("Bengaluru");

            foreach( string t in cities)
            {
                Console.WriteLine(t);
            }


            Dictionary<string, int> country = new Dictionary<string, int>();
            country.Add("In", 2);
            country.Add("Bel", 3);
            

            foreach(KeyValuePair<string,int> kvp in country)
            {
                Console.WriteLine(kvp.Key + "," + kvp.Value);
            }








        }
    }
}
