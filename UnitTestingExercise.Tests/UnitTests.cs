using System;
using Xunit;
using System.Linq;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(3,3,3,9)]
        

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(10, 2, 8)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
       
        public void ReturnD()
        {
            //Arrange-from the class
            var test = new UnitTestMethods();
            
            //Act-actual test.method
            var actual = test.ReturnD();
            //Assert-expected, actual
            Assert.Equal('D', actual);
        }

        [Fact]
        public void SayHEY()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.SayHEY();
            //Assert
            Assert.Equal("HEY", actual);
        }
    }
}
