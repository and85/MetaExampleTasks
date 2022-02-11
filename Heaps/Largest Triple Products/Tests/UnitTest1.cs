using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] { -1, -1, 6, 24, 60 })]
    [InlineData(new int[] {1, 2}, new int[] { -1, -1 })]
    [InlineData(new int[] {}, new int[] { })]
    [InlineData(new int[] {1, 2, 3}, new int[] { -1, -1, 6 })]
    [InlineData(new int[] {1000, 2, 1}, new int[] { -1, -1, 2000 })]
    [InlineData(new int[] {1, 2, 3, 4, 5, 1}, new int[] { -1, -1, 6, 24, 60, 60 })]

    public void Test1(int[] input, int[] expected)
    {      
        // act
        var actual = LargestTripleProducts.findMaxProduct(input);

        // assert
        Assert.Equal(expected, actual);
    }
}