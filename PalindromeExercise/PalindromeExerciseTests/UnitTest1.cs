using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        [InlineData("elite", false)]
        [InlineData("elile", true)]
        public void IsPalindromeTest(string word, bool expected)
        {
            var actual = WordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
