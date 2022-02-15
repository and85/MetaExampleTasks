using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class BalancedSplit
{
    static void Main(string[] args)
    {
        // Call balancedSplitExists() with test cases here
    }

    // O(n logn) - time complexity
    public static bool BalancedSplitExists(int[] arr)
    {
        int totalSum = arr.Sum();
        if (totalSum % 2 == 1)
        {
            return false;
        }
        int halfSum = totalSum / 2;
        Array.Sort(arr);

        int currSum = 0;
        int i;
        for (i = 0; i < arr.Length; i++)
        {
            currSum += arr[i];

            if (currSum > halfSum) { return false; }
            if (currSum == halfSum) { break; }            
        }

        if (i + 1 == arr.Length || arr[i] == arr[i + 1]) { return false; }

        return true;
    }
}