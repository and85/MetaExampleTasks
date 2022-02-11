using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData("abc", "bac")]
    [InlineData("abcd", "bacd")]
    [InlineData("abcxcba", "xbacbca")]
    [InlineData("facebook", "eafcobok")]
    [InlineData("facexbook", "xafceobok")]
    [InlineData("ab", "ab")]
    [InlineData("a", "a")]
    [InlineData("abcxcb", "cabcxb")]
    [InlineData("", "")]
    [InlineData(null, null)]
    
    public void Test1(string input, string expected)
    {
        // act
        var actual = EncryptedWords.findEncryptedWord(input);

        // assert
        Assert.Equal(expected, actual);
    }
}