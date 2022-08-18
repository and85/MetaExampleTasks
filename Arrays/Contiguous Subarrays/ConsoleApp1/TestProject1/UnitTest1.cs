using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {        
        [Theory]
        [InlineData(new[] { 3, 4, 1, 6, 2 }, new[] { 1, 3, 1, 5, 1 })]
        [InlineData(new[] { 2, 4, 7, 1, 5, 3 }, new[] { 1, 2, 6, 1, 3, 1 })]
        public void Test1(int[] input, int[] expected)
        {
            // act
            var actual = ContiguousSubArrays.countSubarrays(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
