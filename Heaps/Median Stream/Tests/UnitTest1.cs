using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new[] { 5, 15, 1, 3 }, new[] { 5, 10, 5, 4 })]        
    /*
    [InlineData(new[] { 1, 2 }, new[] { 1, 1 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 1, 2 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 1, 2, 2, 3, 3, 4})]    
    */
    public void Test1(int[] input, int[] expected)
    {
        // act
        var actual = MedianStream.findMedian(input);

        // assert
        Assert.Equal(expected, actual);
    }
}