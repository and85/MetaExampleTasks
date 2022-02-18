using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class MagicalCandyBags
{
    static void Main(string[] args)
    {
        // Call maxCandies() with test cases here
    }

    public static int maxCandies(int[] arr, int k)
    {
        var queue = new PriorityQueue<int, int>(new ReverseComparer());
        for (int i = 0; i < arr.Length; i++)
        {
            queue.Enqueue(arr[i], arr[i]);
        }

        int total = 0;
        for (int i = 0; i < k; i++)
        {
            int top = queue.Dequeue();
            total += top;
            int refilll = top / 2;
            queue.Enqueue(refilll, refilll);
        }

        return total;
    }

    private class ReverseComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}