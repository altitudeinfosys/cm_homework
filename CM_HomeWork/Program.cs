using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace CM_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            FizzBuzzCombination[] combinations = new FizzBuzzCombination[]
            {
                new FizzBuzzCombination(5,"cool"),
                new FizzBuzzCombination(7,"hot")
            };


            /* you can pass as many combinations as you wish - but if you didn't pass a combination putting null for the parametter, it will
                use the default combination of 3, 5 */

            //FizzBuzz fizzBuzz = new FizzBuzz(1, 100, combinations);
            //default constructor that uses default combiniation 
            //FizzBuzz fizzBuzz = new FizzBuzz(1,100, null);
            FizzBuzz fizzBuzz = new FizzBuzz(1,100, combinations);

            //here we can choose - whether we want to output data to a text file, or to the console

            // through dependency injection - we can designate output to be console for debugging purposes, or text file 
            
            //fizzBuzz.Run(new ConsoleDataOutput());

            fizzBuzz.Run(new TextFileDataOutput());

            Console.WriteLine("Press enter to continue.......");
            Console.ReadLine();


        }
    }
}
