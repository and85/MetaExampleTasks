using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData("Zebra-493?", 3, "Cheud-726?")]
    [InlineData("abcdefghijklmNOPQRSTUVWXYZ0123456789", 39, "nopqrstuvwxyzABCDEFGHIJKLM9012345678")]
    [InlineData("", 39, "")]
    [InlineData(null, 1, null)]
    [InlineData("zzz", 1, "aaa")]
    [InlineData("zzz", 0, "zzz")]
    [InlineData("999", 1, "000")]
    [InlineData("999", 2, "111")]
    public void Test1(string input, int rotationFactor, string expected)
    {        
        // act
        string actual = RotationalCipher.rotationalCipher(input, rotationFactor);

        // assert
        Assert.Equal(expected, actual);
    }
}