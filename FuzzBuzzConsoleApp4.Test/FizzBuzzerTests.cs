using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzzConsoleApp4.Test
{
    [TestFixture] //means this will hold test
    class FizzBuzzerTests
    {
        [Test] //first test shuold be something really basic 
        public void Get_Returns_1_for_1()
        {
            var fizzBuzzer = new FizzBuzzer();
            var result = fizzBuzzer.Get(1); //fizzbuzzer instance that we must create one line above this
            Assert.That(result, Is.EqualTo("1"));//my result is equal to the string 1
        }

        [Test]
        public void Get_Returns_2_for_2()
        {
            var fizzBuzzer = new FizzBuzzer();
            var result = fizzBuzzer.Get(2);
            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Get_Returns_Fizz_for_3()
        {
            var fizzBuzzer = new FizzBuzzer();
            var result = fizzBuzzer.Get(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }


        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3,"Fizz")]//define arguments here
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30,"FizzBuzz")]
        public void Get_Returns_Excpected_Value(int input, string expected) //they get passed through here
        {
            var fizzBuzzer = new FizzBuzzer();
            var result = fizzBuzzer.Get(input);
            Assert.That(result, Is.EqualTo(expected));
        }


    }
}
