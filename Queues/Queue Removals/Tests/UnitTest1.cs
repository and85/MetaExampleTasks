using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{        
    [Theory]
    [InlineData(new[] {1, 2, 2, 3, 4, 5}, 5, new [] {5, 6, 4, 1, 2})]
    [InlineData(new[] {2, 4, 2, 4, 3, 1, 2, 2, 3, 4, 3, 4, 4}, 4, new [] {2, 5, 10, 13})]
    public void Test2(int[] input, int x, int[] expected)
    {        
        // act
        var actual = QueueRemovals.findPositions(input, x);

        // assert
        Assert.Equal(expected, actual);
    }    
}