using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class ReverseToMakeEqual 
{
  static void Main(string[] args) 
  {
    // Call areTheyEqual() with test cases here
  }
  
  public static bool areTheyEqual(int[] arr_a, int[] arr_b) 
  {        
         Array.Sort(arr_a);
         Array.Sort(arr_b); 
        
        for(int i = 0; i < arr_a.Length; i++)
        {
            if (arr_a[i] != arr_b[i])
            {
                return false;
            }
        }
        return true;
    }    
}