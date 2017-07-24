using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class ConsoleDataOutput : IDataSourceWrite
    {
        public void WriteData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
