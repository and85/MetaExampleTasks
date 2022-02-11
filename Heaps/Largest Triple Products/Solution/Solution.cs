using System;
using System.Collections.Generic;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class LargestTripleProducts 
{
  static void Main(string[] args) 
  {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        findMaxProduct(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
  
  public static int[] findMaxProduct(int[] arr) 
  {
        // Write your code here
        var queue = new PriorityQueue<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            queue.Enqueue(arr[i], arr[i]);

            if (queue.Count > 3)
            {
                queue.Dequeue();
            }

            if (queue.Count == 3)
            {
                arr[i] = queue.UnorderedItems.Select(i => i.Priority).Aggregate(1, (x,y) => x * y);
            }
            else
            {
                arr[i] = -1;
            }

        }

            
        return arr;
    }
}