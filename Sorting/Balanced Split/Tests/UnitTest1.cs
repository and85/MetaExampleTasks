using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]    
    [InlineData(new[] { 1, 5, 7, 1 }, true)]
    [InlineData(new[] { 12, 7, 6, 7, 6 }, false)]
    [InlineData(new[] { 1, 2, 3, 6 }, true)]
    [InlineData(new[] { 1, 1, 2, 3, 6 }, false)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, false)]
    [InlineData(new[] { 0, 0, 2, 1, 3 }, true)]
    [InlineData(new[] { 0 }, false)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 2, 4 }, true)]
    [InlineData(new[] { 1, 1, 1, 2, 4 }, false)]
    [InlineData(new[] { 5, 5, 11 }, false)]
    [InlineData(new[] { 5, 6, 11 }, true)]
    [InlineData(new[] { 3, 6, 3, 4, 4 }, false)]
    [InlineData(new[] { 1, 2 }, false)]
    [InlineData(new[] { 0, 0 }, false)]
    [InlineData(new[] { 1, 1 }, false)]
    [InlineData(new[] { 2 }, false)]
    [InlineData(new[] { 20, 2 }, false)]
    [InlineData(new[] { 5, 7, 20, 12, 5, 7, 6, 14, 5, 5, 6 }, true)]
    [InlineData(new[] { 5, 7, 20, 12, 5, 7, 6, 7, 14, 5, 5, 6 }, false)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, false)]
    [InlineData(new[] { 6,1,2,3,3,4,5 }, false)]
    [InlineData(new[] { 11,6,1,2,13,3,3,4,5}, true)]

    public void Test1(int[] input, bool expected)
    {        
        // act
        //var actual = BalancedSplit.BalancedSplitExists(new int[] {1, 1, 2, 4});
        var actual = BalancedSplit.BalancedSplitExists(input);

        // assert
        Assert.Equal(expected, actual);
    }
}