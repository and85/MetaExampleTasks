using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class QueueRemovals {
  static void Main(string[] args) {
    // Call findPositions() with test cases here
  }
  
  public static int[] findPositions(int[] arr, int x)
    {
        int[] result = new int[x];        

        // value - index
        var queue = new Queue<(int, int)>();
        InitQueue(arr, queue);

        for (int i = 0; i < x; i++)
        {
            result[i] = PerformIteration(queue, x);
        }


        return result;
    }

    private static int PerformIteration(Queue<(int, int)> queue, int x)
    {        
        var popQueue = new Queue<(int, int)>();
        var maxExlement = (-1, -1);

        for (int i = 0; i < x && queue.Count > 0; i++)
        {            
            var el = queue.Dequeue();

            if (el.Item1 > maxExlement.Item1)
            {
              maxExlement = el;             
            }

            popQueue.Enqueue(el);
        }

        while (popQueue.Count > 0)
        {
            var element = popQueue.Dequeue();
            if (element.Item2 == maxExlement.Item2) continue;

            queue.Enqueue((element.Item1 > 0 ? element.Item1 - 1 : 0, element.Item2));
        }


        return maxExlement.Item2;
    }

    private static void InitQueue(int[] arr, Queue<(int, int)> queue)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            queue.Enqueue((arr[i], i + 1));
        }
    }
}