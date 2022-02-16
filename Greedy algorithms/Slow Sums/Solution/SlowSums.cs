using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class SlowSums {
  static void Main(string[] args) {
    // Call getTotalTime() with test cases here
  }
    
  public static int GetTotalTime(int[] arr) {        
        
        // TODO: another faster approach would be to use a Heap
        
        // time and space complexity depends on the size of the array, if array is small, insertion sort will be used, 
        // for bigger arrays more advanced algotithms like quicksort will be used
        Array.Sort(arr);
        
        // O(n)
        Array.Reverse(arr);

        // O(n)
        int sum = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i + 1] = arr[i] + arr[i + 1];
            sum += arr[i + 1];
        }

        return sum;
    }
}