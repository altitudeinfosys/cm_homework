using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public sealed class FizzBuzzCombination
    {
        private int divisorValue;
        public int Divisor { get { return divisorValue; } }

        private string messageValue;
        public string Message { get { return messageValue; } }

        public bool Found { get; set; }

        public FizzBuzzCombination(int divisor, string message)
        {
            if (divisor <= 0)
                throw new ArgumentOutOfRangeException("divisor", new Exception("divisor must be greater than zero"));
            divisorValue = divisor;

            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException("message");
            messageValue = message;
        }

        public static IEnumerable<FizzBuzzCombination> Default
        {
            get
            {
                return new List<FizzBuzzCombination>()
                {
                    new FizzBuzzCombination(3, "fizz"),
                    new FizzBuzzCombination(5, "buzz")
                };
            }
        }

        
    }
}
