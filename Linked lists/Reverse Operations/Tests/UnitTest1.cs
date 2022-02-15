using Xunit;
using static Solution;

namespace Tests;

public class UnitTest1
{
    [Fact]    
    public void Test1()
    {
        // arrange
        var solution = new Solution();        
        var n1 = new Node(1);
        var n2 = new Node(2);
        var n8 = new Node(8);
        var n9 = new Node(9);
        var n12 = new Node(12);
        var n16 = new Node(16);
        n1.Next = n2;
        n2.Next = n8;
        n8.Next = n9;
        n9.Next = n12;
        n12.Next = n16;        


        // act
        var actual = solution.Reverse(n1);

        // assert
        // 1, 8, 2, 9, 16, 12
        //Assert.Equal(expected, actual);
    }

    [Fact]    
    public void Test2()
    {
        // arrange
        var solution = new Solution();        
        var n1 = new Node(1);
        var n2 = new Node(2);
        var n3 = new Node(3);
        var n4 = new Node(4);
        var n5 = new Node(5);
        var n6 = new Node(6);
        n1.Next = n2;
        n2.Next = n3;
        n3.Next = n4;
        n4.Next = n5;
        n5.Next = n6;        

        // act
        var actual = solution.Reverse(n1);

        // assert
        // 1, 2, 3, 4, 5, 6
        //Assert.Equal(expected, actual);
    }

    [Fact]    
    public void Test3()
    {        
        // arrange
        var solution = new Solution();        
        var n2 = new Node(2);
        var n4 = new Node(4);
        var n6 = new Node(6);
        var n9 = new Node(9);
        var n12 = new Node(12);
        var n14 = new Node(14);
        var n16 = new Node(16);
        
        n2.Next = n4;
        n4.Next = n6;
        n6.Next = n9;
        n9.Next = n12;
        n12.Next = n14;        
        n14.Next = n16;        

        // act
        var actual = solution.Reverse(n2);

        // assert
        // 6, 4, 2, 9, 16, 14, 12
        //Assert.Equal(expected, actual);
    }

    [Fact]    
    public void Test4()
    {
        // arrange
        var solution = new Solution();        
        var n2 = new Node(2);
        var n4 = new Node(4);
        var n6 = new Node(6);
        var n9 = new Node(9);
        var n11 = new Node(11);
        var n12 = new Node(12);
        var n14 = new Node(14);
        var n16 = new Node(16);
        var n17 = new Node(17);
        
        n2.Next = n4;
        n4.Next = n6;
        n6.Next = n9;
        n9.Next = n11;
        n11.Next = n12;        
        n12.Next = n14;        
        n14.Next = n16;        
        n16.Next = n17;        

        // act
        var actual = solution.Reverse(n2);

        // assert
        // 6, 4, 2, 9, 11, 16, 14, 12, 17
        //Assert.Equal(expected, actual);
    }   
}