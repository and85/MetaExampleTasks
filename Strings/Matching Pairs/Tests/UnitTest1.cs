using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]
    [InlineData("abcd", "abcx", 2)]
    [InlineData("abca", "abcx", 3)]
    [InlineData("abcd", "adcb", 4)]
    [InlineData("abcd", "abcd", 2)]
    [InlineData("abcdefg", "bacdefg", 7)]
    [InlineData("abcdefb", "bbcdefk", 6)]
    [InlineData("mno", "mno", 1)]
    [InlineData("mno", "mn", 0)]
    [InlineData("", "", 0)]
    [InlineData(null, "", 0)]
    [InlineData(null, null, 0)]
    [InlineData("abcdefghij", "abxdechzzz", 5)]
    [InlineData("abcdefghij", "abxdecgzzz", 6)]
    public void Test1(string s, string t, int expected)
    {        
        // act
        var actual = MatchingPairs.matchingPairs(s, t);

        // assert
        Assert.Equal(expected, actual);
    }
}