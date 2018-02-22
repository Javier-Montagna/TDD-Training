using System;
using Xunit;
using FibonacciSln.Models;

namespace FibonacciSln.Tests
{
    public class FibonacciUnitTests
    {
        [Fact]
        public void Fib_Given0_Return0()
        {
            //Arrange
            int n = 0;

            //Act
            int result = new Fibonacci().Fib(n);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Fib_Given1_Return1()
        {
            //Arrange
            int n = 1;

            //Act
            int result = new Fibonacci().Fib(n);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fib_Given2_Return1()
        {
            //Arrange
            int n = 2;

            //Act
            int result = new Fibonacci().Fib(n);

            //Assert
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Fib_Given3_Return2()
        {
            //Arrange
            int n = 3;

            //Act
            int result = new Fibonacci().Fib(n);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Fib_Given11_Return89()
        {
            //Arrange
            int n = 11;

            //Act
            int result = new Fibonacci().Fib(n);

            //Assert
            Assert.Equal(89, result);
        }
    }
}
