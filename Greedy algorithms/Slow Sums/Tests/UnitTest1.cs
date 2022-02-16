using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new[] {4, 2, 1, 3 }, 26)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 50)]
    [InlineData(new[] { 2, 3, 9, 8, 4 }, 88)]
    public void Test1(int[] input, int expected)
    {        
        // act
        var actual = SlowSums.GetTotalTime(input);

        // assert
        Assert.Equal(expected, actual);
    }
}