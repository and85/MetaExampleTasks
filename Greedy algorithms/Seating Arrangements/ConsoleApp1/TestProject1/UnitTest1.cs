using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 5, 10, 6, 8 }, 4)]
        [InlineData(new int[] { 1, 2, 5, 3, 7 }, 4)]
        [InlineData(new int[] { 1, 10, 100 }, 99)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 990)]
        public void Test1(int[] arr, int expected)
        {
            // act
            var actual = SeatingArrangements.minOverallAwkwardness(arr);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
