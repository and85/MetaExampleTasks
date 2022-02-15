using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData("", true)]
    [InlineData("{[()]}", true)]
    [InlineData("{([)]}", false)]
    [InlineData("{}()", true)]
    [InlineData("{}", true)]
    [InlineData("[]", true)]
    [InlineData("()", true)]
    [InlineData("{{}", false)]
    [InlineData("{{}}", true)]
    [InlineData("[]", true)]
    [InlineData("[[]", false)]
    [InlineData("[[]]", true)]
    [InlineData("()", true)]
    [InlineData("(()", false)]
    [InlineData("(())", true)]
    [InlineData("({}))", false)]
    [InlineData(")", false)]
    [InlineData("(", false)]
    [InlineData("{(})", false)]
    public void Test1(string input, bool expected)
    {        
        // act
        var actual = BalancedBrackers.IsBalanced(input);

        // assert
        Assert.Equal(expected, actual);
    }
}