using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]        
    public void Test1()
    {
        // arrange
        int input = 1;
        int expected = 0;
        var solution = new Solution();

        // act
        var actual = solution.Method1(input);

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(1, 0)]
    public void Test2(int input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.Method1(input);

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [ClassData(typeof(TestData))]
    public void Test3(int input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.Method1(input);

        // assert
        Assert.Equal(expected, actual);
    }

    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 0 };
            yield return new object[] { 2, 1 };            
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }    
}