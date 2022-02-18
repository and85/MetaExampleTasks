using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData("dcbefebce", "fd", 5)]
    [InlineData("dcbdfebce", "fd", 2)]
    [InlineData("dcbefebcefd", "fd", 5)]
    public void Test1(string s, string t, int expected)
    {        
        // act
        var actual = MinimumLengthSubstrings.minLengthSubstring(s, t);

        // assert
        Assert.Equal(expected, actual);
    }
}