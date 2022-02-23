using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new[] { 3, 4, 1, 6, 2 }, new[] { 1, 3, 1, 5, 1 })]
    public void Test(int[] input, int[] expected)
    {
        // act
        var actual = ContiguousSubArrays.countSubarrays(input);

        // assert
        Assert.Equal(expected, actual);
    }
}