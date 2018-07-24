﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace BinarySerialization
{
    class SerializeData
    {
        FileStream file = null;

        public void SaveData(PersonInfo pi)
        {
            try
            {
                file = new FileStream("C:\\Files\\PersonInfo.bin", FileMode.Create , FileAccess.ReadWrite );

                BinaryFormatter format = new BinaryFormatter();
                format.Serialize(file, pi);
                Console.WriteLine("Data Serialized");
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
        }


        public PersonInfo GetData()
        {
            PersonInfo ps = null; 
            try
            {
                file = new FileStream("C:\\Files\\PersonInfo.bin", FileMode.Open, FileAccess.Read);

                BinaryFormatter format = new BinaryFormatter();
                ps = (PersonInfo)format.Deserialize(file);
                Console.WriteLine("Data Serialized");
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
            return ps;
        }

    }
}
