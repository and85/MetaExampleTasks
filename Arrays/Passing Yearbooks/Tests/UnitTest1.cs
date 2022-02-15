using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new[] { 2, 1 }, new[] { 2, 2 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 1 })]
    public void Test1(int[] input, int[] expected)
    {
        // act
        var actual = PassingYearbooks.FindSignatureCounts(input);

        // assert
        Assert.Equal(expected, actual);
    }
}