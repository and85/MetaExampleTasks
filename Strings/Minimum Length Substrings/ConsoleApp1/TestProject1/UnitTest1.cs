using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dcbefebce", "fd", 5)]
        [InlineData("dcbefdebce", "fd", 2)]
        [InlineData("dcbefdebce", "fd", 2)]
        [InlineData("ADOBECODEBANC", "ABC", 4)]
        [InlineData("a", "a", 1)]
        [InlineData("a", "aa", -1)]
        [InlineData("bfbeadbcbcbfeaaeefcddcccbbbfaaafdbebedddf", "cbccfafebccdccebdd", -1)]
        public void Test1(string s, string t, int expected)
        {
            // arrange
            var solution = new MinLengthSubstring();

            // act
            var actual = solution.minLengthSubstring(s, t);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
