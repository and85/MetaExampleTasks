using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class ElementSwapping
{
    static void Main(string[] args)
    {
        // Call findMinArray() with test cases here
    }

    public static int[] findMinArray(int[] arr, int k)
    {
        int[] arrBeginning = new int[arr.Length];
        int[] arrEnd = new int[arr.Length];
        Array.Copy(arr, arrBeginning, arr.Length);
        Array.Copy(arr, arrEnd, arr.Length);
        FindMinArrayBeginning(arrBeginning, k);
        FindMinArrayEnd(arrEnd, k);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arrBeginning[i] < arrEnd[i])
            {
                return arrBeginning;
            }
            else if (arrEnd[i] < arrBeginning[i])
            {
                return arrEnd;
            }

        }

            return arrBeginning;
    }    

    private static void FindMinArrayBeginning(int[] arr, int k)
    {
        if (k == 0) return;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                Swap(arr, i - 1, i);
                FindMinArrayBeginning(arr, k - 1);
                break;
            }
        }        
    }

    private static void FindMinArrayEnd(int[] arr, int k)
    {
        if (k == 0) return;

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(arr, i + 1, i);
                FindMinArrayEnd(arr, k - 1);
                break;
            }
        }

        return;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }
}