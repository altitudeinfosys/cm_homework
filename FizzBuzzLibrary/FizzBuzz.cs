using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {

        /* Client -want to have the ablity to edit, review the data - so I will be saving it a text file. I am implementing,
         * through an interface, which will provide the ability through dependency injection - to change the datasource if 
         needed - */

        public int EndPoint { get; set; }
        public int StartingPoint { get; set; }
        private FizzBuzzCombination[] _combinations;
        private string _allMessage;
        private int _allDivisors=1;
        private bool defaultCombination;
        
        
        public FizzBuzz(int start, int end, params FizzBuzzCombination[] combinations)           
        {
            if (end <= 0)
                throw new ArgumentException("The value for parameter \"EndPoint\" must be greater than 0");

            if (start > end)
                throw new ArgumentException("The value for parameter \"EndPoint\" is less than \"Starting point \" value");

            this.StartingPoint = start;
            this.EndPoint = end;


            if (null == combinations)
                this._combinations = FizzBuzzCombination.Default.ToArray(); //if combination is not passed use default of 3 and 5
            else                                                            // otherwise use the combinations provided
            {
                this._combinations = combinations;
            }

           

            foreach (var comb in _combinations)
            {
                _allDivisors *= comb.Divisor;
                _allMessage = _allMessage + comb.Message;
            }
        }

       

        //overriding the run method - if no data output method has been passed - use the console as default 
        public void Run()
        {
            Run(new ConsoleDataOutput());

        } // end run 

        public void Run(IDataSourceWrite output)
        {
           
            

            for (int i = StartingPoint; i <= EndPoint; ++i)
            {
                output.WriteData(CheckFizzBuzz(i));
            }

        } // end run 

        

        public string CheckFizzBuzz(int i)
        {
            bool found = false;
            string sendBack="";


            //this if statement to handle the cumulative condition - of fizz and buzz situation or whatever message is assigned 
            // i.e (i%5==0) && (i%3==0)
            if ((i % _allDivisors) == 0)
            {
                found = true;
                sendBack = _allMessage;            
            }

            if(!found)
            foreach (var comb in _combinations)
            {
                if ((i % comb.Divisor) == 0)
                {
                    found = true;
                    sendBack = comb.Message;                                    
                }
            }

            if (!found)
            {
                sendBack = i.ToString();
                
                
            }

            return sendBack;

        } // end fizzBuzzCheck

    }
}
