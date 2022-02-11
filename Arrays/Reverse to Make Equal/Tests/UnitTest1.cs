using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]    
    [InlineData(new[] {1, 2, 3, 4}, new[] {1, 4, 3, 2}, true)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] {1, 3, 2, 4, 8, 7, 6, 5}, true)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] {1, 3, 2, 4, 8, 7, 6, 4}, false)]    
    [InlineData(new[] { 1, 1, 1 }, new[] {1, 1, 1}, true)]   
    [InlineData(new[] { 1, 1, 2 }, new[] {2, 1, 1}, true)]       
    [InlineData(new[] { 1, 2, 1 }, new[] {2, 1, 2}, false)]   
    [InlineData(new[] { 1, 2, 1 }, new[] {2, 1, 1}, true)]   
    [InlineData(new[] { 1, 2, 1 }, new[] {1, 1, 2}, true)]       
    public void Test1(int[] a, int[] b, bool expected)
    {        
        // act
        var actual = ReverseToMakeEqual.areTheyEqual(a, b);

        // assert
        Assert.Equal(expected, actual);
    }
}