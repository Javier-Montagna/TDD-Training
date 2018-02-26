using System;
using Xunit;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [Fact]
        public void ShouldPrintNumber()
        {
            Assert.Equal("1", _fizzBuzz.Print(1));
        }

        [Fact]
        public void ShouldPrintFizz()
        {
            Assert.Equal("Fizz", _fizzBuzz.Print(3));
        }

        [Fact]
        public void ShouldPrintBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzz.Print(5));
        }

        [Fact]
        public void ShouldPrintFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzz.Print(15));
        }
    }
}
