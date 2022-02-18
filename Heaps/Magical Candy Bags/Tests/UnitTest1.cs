using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]
    [InlineData(new[] {2, 1, 7, 4, 2}, 3, 14)]
    public void Test1(int[] input, int k, int expected)
    {        
        // act
        var actual = MagicalCandyBags.maxCandies(input, k);

        // assert
        Assert.Equal(expected, actual);
    }
}