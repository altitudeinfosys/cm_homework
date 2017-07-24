using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class TextFileDataOutput : IDataSourceWrite
    {
        
        public TextFileDataOutput()
        {
            //constructor will clear out the file and start from scratch - each time the Run method is called from the library
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" +  "data.txt", string.Empty); 
        }
        public void WriteData(string data)
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + "data.txt", true);

            // write a line of text to the file
            tw.WriteLine(data);

            // close the stream
            tw.Close();
        }
/*
        public void ReadData()
        {
            // create reader & open file
            TextReader tr = new StreamReader("data.txt");

            // read a line of text
            Console.WriteLine(tr.ReadLine());

            // close the stream
            tr.Close();
        }*/
    }


}
