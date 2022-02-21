using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class CountingTriangles {
  static void Main(string[] args) {
    // Call countDistinctTriangles() with test cases here
  }
    
  public static int countDistinctTriangles(int[,] arr) {

        var hashSet = new HashSet<string>();

        for (int r = 0; r < arr.Length / 3; r++)
        {            
            var sides = new int[] { arr[r, 0], arr[r, 1], arr[r, 2]};
            Array.Sort(sides);

            var t = string.Join('|', sides);

            if (!hashSet.Contains(t))
            {
                hashSet.Add(t);
            }
        }

        return hashSet.Count;
    }
}