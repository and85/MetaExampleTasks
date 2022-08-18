using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 5, 4, 3 }, 1)]
        public void Test1(int[] arr, int expected)
        {
            // arrange

            // act
            var actual = MinimizingPermutations.MinOperations(arr);

            // assert
            Assert.Equal(expected, actual);
        }


    }
}
