using System;
using Xunit;
using UnitTestingExercise;
namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2,3,5,10)]
        [InlineData(2,2,5,9)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,8,2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(10,3,30)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(20,2,10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetSalutation()
        {
            //Arrange
            var obj = new UnitTestMethods();
            string expected = "Hello World";
            //Act
            var actual =obj.GetSalutation();
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void NoteRate()
        {
            //Arrange
            var obj = new UnitTestMethods();
            decimal expected = (decimal) 4.5;
            //Act
            var actual = obj.NoteRate();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
