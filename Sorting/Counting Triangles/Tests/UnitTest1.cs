using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [ClassData(typeof(TestData))]
    public void Test1(int[,] input, int expected)
    {
        // act
        var actual = CountingTriangles.countDistinctTriangles(input);

        // assert
        Assert.Equal(expected, actual);
    }

    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[,] { { 2, 2, 3 }, { 3, 2, 2 }, { 2, 5, 6 } }, 2 };
            yield return new object[] { new int[,] { { 2, 2, 3 }, { 3, 2, 2 }, { 2, 5, 6 }, { 2, 2, 3 } }, 2 };
            yield return new object[] { new int[,] { { 8, 4, 6 }, { 100, 101, 102 }, { 84, 93, 173 } }, 3 };
            yield return new object[] { new int[,] { { 5, 8, 9 }, { 5, 9, 8 }, { 9, 5, 8 }, { 9, 8, 5 }, { 8, 9, 5 }, { 8, 5, 9 } }, 1 };
            yield return new object[] { new int[,] { { 2, 2, 3 } }, 1 };
            yield return new object[] { new int[,] { { 2, 2, 3 }, { 2, 2, 3 } }, 1 };
            yield return new object[] { new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1_000_000_000, 1_000_000_000, 1_000_000_000 }, { 1_000_000_000, 1_000_000_000, 1_000_000_000 } }, 2 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}