using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]        
    public void Test1()
    {
        // arrange
        var solution = new Solution();
        var n8 = new Node(8);
        var n3 = new Node(3);
        var n10 = new Node(10);
        var n1 = new Node(1);
        var n6 = new Node(6);
        var n14 = new Node(14);
        var n4 = new Node(4);
        var n7 = new Node(7);
        var n13 = new Node(13);

        n8.Left = n3;
        n8.Right = n10;
        n3.Left = n1;
        n3.Right= n6;
        n10.Right= n14;
        n6.Left= n4;
        n6.Right= n7;
        n14.Left= n13;

        // act
        var actual = solution.VisibleNodes(n8);

        // assert
        Assert.Equal(4, actual);
    }

    [Fact]        
    public void Test2()
    {
        // arrange
        var solution = new Solution();
        var n8 = new Node(8);
        

        // act
        var actual = solution.VisibleNodes(n8);

        // assert
        Assert.Equal(1, actual);
    }

    [Fact]        
    public void Test3()
    {
        // arrange
        var solution = new Solution();
        var n8 = new Node(8);
        
        var n10 = new Node(10);
                
        n8.Right = n10;
        

        // act
        var actual = solution.VisibleNodes(n8);

        // assert
        Assert.Equal(2, actual);
    }
}