using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}, new[] {100, 200, 500}, new[] {4, 6, 10} )]    
    [InlineData(new[] {10, 20, 30}, new[] {10, 20, 30}, new[] {1, 2, 2} )]
    [InlineData(new[] {100, 2000, 30000}, new[] {100, 2000, 30000}, new[] {1, 2, 3} )]
    [InlineData(new[] {10, 2000, 30000}, new[] {100, 2000, 30000}, new[] {2, 2, 3} )]
    [InlineData(new[] {10, 20, 30}, new[] {10, 20, 300}, new[] {1, 2, -1} )]
    [InlineData(new[] {10, 20, 30}, new[] {1000, 2000, 3000}, new[] {-1, -1, -1} )]
    [InlineData(new[] {10, 20, 3000}, new[] {1000, 2000, 3000}, new[] {3, 3, 3} )]
    [InlineData(new[] {10000, 20, 30}, new[] {1000, 2000, 3000}, new[] {1, 1, 1} )]    
    public void Test1(int[] revenues, int[] milestones, int[] expected)
    {        
        // act
        var actual = RevenueMilestones.GetMilestoneDays(revenues, milestones);

        // assert
        Assert.Equal(expected, actual);
    }
}