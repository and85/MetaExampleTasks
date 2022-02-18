using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(94, new[] {5, 10, 25, 100, 200}, false)]
    [InlineData(75, new[] {4, 17, 29}, true)]
    [InlineData(75, new[] {1, 4, 17, 29, 74}, true)]
    [InlineData(75,new[] {4, 17, 29, 74}, true)]
    [InlineData(103, new[] {4, 17, 29, 74}, true)]
    [InlineData(103, new[] {4, 17, 28, 74}, true)]
    [InlineData(103, new[] {1, 17, 28, 74}, true)]
    //[InlineData(999999, new[] {54,52,50,48,46,44,42,40,38,36,34,32,30,28,26,24,22,20,18,16,14,12,10,8,6,4,2}, false)]
    public void Test1(int targetMoney, int[] denominations, bool expected)
    {        
        // act
        var actual = ForeignCurrency.canGetExactChange(targetMoney, denominations);

        // assert
        Assert.Equal(expected, actual);
    }
}