using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
public class ContiguousSubArrays {
  static void Main(string[] args) {
    // Call countSubarrays() with test cases here
  }
  
  public static int[] countSubarrays(int[] arr) {    
    int n = arr.Length;
    var left = new int[arr.Length];
    var right = new int[arr.Length];

    Array.Fill(left, 1, 0, left.Length);
    Array.Fill(right, 1, 0, right.Length);      

    /*
    let consec = 0;
    let max = {
      val: arr[0],
      pos: 0
    };
    for (let i = 1; i < N; i++) {
      const curr = arr[i];
      const prev = arr[i - 1];
      if (curr > max.val) {
        left[i] += left[max.pos] + (i - max.pos - 1)
        max.val = curr;
        max.pos = i;
      } else if (curr > prev) {
        left[i] += ++consec;
      } else {
        consec = 0;
      }
    }
    consec = 0;
    max = {
      val: arr[N - 1],
      pos: N - 1
    };
    for (let i = N - 2; i >= 0; i--) {
      const curr = arr[i];
      const prev = arr[i + 1];
      if (curr > max.val) {
        right[i] += right[max.pos] + (max.pos - i - 1)
        max.val = curr;
        max.pos = i;
      } else if (curr > prev) {
        right[i] += ++consec;
      } else {
        consec = 0;
      }
    }
    const res = new Array(N).fill(1);
    for (let i = 0; i < left.length; i++) {
      res[i] = left[i] + right[i] - 1
    }
    return res
    */
    return null;
  }
}