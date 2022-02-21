using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class MedianStream
{
    static void Main(string[] args)
    {
        // Call findMedian() with test cases here
    }

    public static int[] findMedian(int[] arr)
    {
        var minHeap = new PriorityQueue<int, int>();
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => { return y.CompareTo(x); }));

        int median = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            median = GetMedian(arr[i], median, maxHeap, minHeap);
            arr[i] = median;
        }

        return arr;
    }

    private static int GetMedian(int element, int median, PriorityQueue<int, int> left, PriorityQueue<int, int> right)
    {
        if (right.Count == left.Count)
        {                   
            if (element < median)
            {
                left.Enqueue(element, element);
                return left.Peek();
            }
            else if (element >= median)
            {
                right.Enqueue(element, element);
                return right.Peek();
            }
        }
        else if (right.Count > left.Count)
        {
            if (element < median)
            {
                
                left.Enqueue(element, element);
                return (left.Peek() + right.Peek()) / 2;
            }            
            else if (element >= median)
            {
                int top = right.Dequeue();
                left.Enqueue(top, top);

                right.Enqueue(element, element);                
                return (left.Peek() + right.Peek()) / 2;
            }            
        }
        else if (left.Count > right.Count)
        {
            if (element < median)
            {                
                int top = left.Dequeue();
                right.Enqueue(top, top);

                left.Enqueue(element, element);                
                return (left.Peek() + right.Peek()) / 2;
            }
            else if (element >= median)
            {
                right.Enqueue(element, element);
                return (left.Peek() + right.Peek()) / 2;
            }            
        }

        return 0;
    }
}