using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PalindromeExercise;


namespace PalindromeExerciseTests
{
    public class PlanidromeTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("book",false)]
        [InlineData("Racecar", true)]
        [InlineData("Racecars", false)]

        
        public void IsAPalindrome(string pally,bool expected)
        {
            //Arrange
            WordSmith sut = new WordSmith();

            //Act
            var actual = sut.PalFinder(pally);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
