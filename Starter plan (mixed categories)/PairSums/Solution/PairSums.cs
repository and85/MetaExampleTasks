using System;
using System.Linq;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class PairSums {
  static void Main(string[] args) {
    // Call numberOfWays() with test cases here
  }
  
  // O(n) time, O(n) space
  public static int numberOfWays(int[] arr, int k) {
        int result = 0;

        var countDict = arr.GroupBy(e => e).ToDictionary(e => e.Key, e => e.Count());

        for (int i = 0; i < arr.Length; i++)
        {
            int key = k - arr[i];
            int count = countDict.ContainsKey(key) ? countDict[key] : 0;

            if (arr[i] == key)
            {
                count--;
            }

            result += count;
        }

        return result / 2;
    }
}