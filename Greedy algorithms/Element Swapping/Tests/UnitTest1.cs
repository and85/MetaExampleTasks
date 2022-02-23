using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new[] { 5, 3, 1 }, 2, new[] { 1, 5, 3 })]    
    [InlineData(new[] { 8, 9, 11, 2, 1 }, 3, new[] { 2, 8, 9, 11, 1 })]    
    [InlineData(new[] { 8, 9, 11, 8, 1 }, 3, new[] { 8, 8, 9, 1, 11 })]    
    [InlineData(new[] { 8, 11, 9, 2, 1 }, 3, new[] { 2, 8, 11, 9, 1 })]    
    [InlineData(new[] { 2, 2, 2, 2, 1 }, 2, new[] { 2, 2, 1, 2, 2 })]    
    [InlineData(new[] { 2, 2, 2, 2, 1 }, 0, new[] { 2, 2, 2, 2, 1 })]    
    [InlineData(new[] { 1, 2, 2, 2, 2 }, 1, new[] { 1, 2, 2, 2, 2 })]    
    [InlineData(new[] { 5, 3, }, 2, new[] { 1, 2, 2, 2, 2 })]
    [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 }, 2, new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
    [InlineData(new[] { 1, 1, 1, 1, 3, 2, 1, 1, 1, 1 }, 2, new[] { 1, 1, 1, 1, 1, 1, 3, 2, 1, 1 })]
    public void Test1(int[] input, int k, int[] expected)
    {
        // act
        var actual = ElementSwapping.findMinArray(input, k);

        // assert
        Assert.Equal(expected, actual);
    }
}