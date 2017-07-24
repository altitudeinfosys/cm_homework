using System;
using FizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzBuzz
    {
        //will test the 15 situation and whether at count 15 - it does show FizzBuzz under the default configuraiton
        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_Only_15()
        {
            //this will run under default configuration 

            //arrange section
            string expected = "fizzbuzz";
            int i = 15;

            //act
            FizzBuzz fizzBuzz = new FizzBuzz(1,100, null); // fizz buzz library with default configuration
            string actual =fizzBuzz.CheckFizzBuzz(i);

            //assert
            Assert.AreEqual(expected,actual);
            

        }
        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_coolhot_When_Number_Is_Divisible_By_Only_35_under_different_combination()
        {
            //this will run under default configuration 

            //arrange section
            string expected = "coolhot";
            int i = 35;

            //act
            FizzBuzzCombination[] combinations = new FizzBuzzCombination[]
            {
                new FizzBuzzCombination(5,"cool"),
                new FizzBuzzCombination(7,"hot")
            };

            FizzBuzz fizzBuzz = new FizzBuzz(1, 100, combinations); // fizz buzz library with default configuration
            string actual = fizzBuzz.CheckFizzBuzz(i);

            //assert
            Assert.AreEqual(expected, actual);


        }


    }
}
