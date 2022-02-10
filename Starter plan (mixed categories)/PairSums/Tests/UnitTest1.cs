using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3 }, 6, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 4 }, 6, 3)]
    [InlineData(new int[] { 1, 5, 3, 3, 3 }, 6, 4)]
    [InlineData(new int[] { 1, 2, 2, 4, 1, 3 }, 6, 2)]
    [InlineData(new int[] { 1, 2 }, 3, 1)]
    [InlineData(new int[] { 1, 1 }, 3, 0)]
    [InlineData(new int[] { 1, 1 }, 1, 0)]
    [InlineData(new int[] { 1, 1, 2, 2 }, 3, 4)]
    [InlineData(new int[] { 1000000000, 1000000000  }, 1000000000, 0)]
    [InlineData(new int[] { 500000000, 500000000  }, 1000000000, 1)]
    public void Test1(int[] input, int k, int expected)
    {        
        // act
        var actual = PairSums.numberOfWays(input, k);

        // assert
        Assert.Equal(expected, actual);
    }
}