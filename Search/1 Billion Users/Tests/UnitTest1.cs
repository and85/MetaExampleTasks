using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new float[] { 1.5f }, 52)]
    [InlineData(new float[] { 1.1f, 1.2f, 1.3f }, 79)]
    [InlineData(new float[] { 1.01f, 1.02f }, 1047)]
    [InlineData(new float[] { 10 }, 9)]
    public void Test_BinarySearch(float[] growthRates, int expected)
    {
        // act
        var actual = BillionUsers.GetBillionUsersDay(growthRates);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new float[] { 1.5f }, 52)]
    [InlineData(new float[] { 1.1f, 1.2f, 1.3f }, 79)]
    [InlineData(new float[] { 1.01f, 1.02f }, 1047)]
    [InlineData(new float[] { 10 }, 9)]
    public void Test_BruteForce(float[] growthRates, int expected)
    {
        // act
        var actual = BillionUsers.GetBillionUsersDay_BruteForce(growthRates);

        // assert
        Assert.Equal(expected, actual);
    }
}