using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 7, 3, 14)]
        [InlineData(-3, 6, 1, 4)]
        [InlineData(-10, -2, -2, -14)]
        [InlineData(24, 5, 1, 30)]
        [InlineData(18, 9, 2, 29)]
        [InlineData(-8, 7, 6, 5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();


            //Act
            int actual = challenger.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(76, 9, 67)]
        [InlineData(8, 2, 6)]
        [InlineData(-4, 6, -10)]
        [InlineData(-13, -3, -10)]
        [InlineData(8, 9, -1)]
        [InlineData(5, 2, 3)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(-7, 7, -49)]
        [InlineData(0, 4, 0)]
        [InlineData(8, 4, 32)]
        [InlineData(-2, -6, 12)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var challenger = new Calculator();

            //Act
            int actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 5, 3)]
        [InlineData(49, -7, -7)]
        [InlineData(-36, 6, -6)]
        [InlineData(10, 3, 3)]
        [InlineData(8, 6, 1)]
        [InlineData(4, 2, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            var actual = challenger.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
