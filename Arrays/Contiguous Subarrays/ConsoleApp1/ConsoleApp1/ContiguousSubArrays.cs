using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{    
    public class ContiguousSubArrays
    {
        static void Main(string[] args)
        {
            // Call countSubarrays() with test cases here
        }

        public static int[] countSubarrays(int[] arr)
        {
            return NotMySolution(arr);
        }

        private static int[] NotMySolution(int[] arr)
        {
            int n = arr.Length;
            var left = new int[n];
            var right = new int[n];

            Array.Fill(left, 1);
            Array.Fill(right, 1);

            int consec = 0;
            var max = (val: arr[0], pos: 0);

            for (int i = 1; i < n; i++)
            {
                int curr = arr[i];
                int prev = arr[i - 1];
                if (curr > max.val)
                {
                    left[i] += left[max.pos] + (i - max.pos - 1);
                    max.val = curr;
                    max.pos = i;
                }
                else if (curr > prev)
                {
                    left[i] += ++consec;
                }
                else
                {
                    consec = 0;
                }
            }

            consec = 0;
            max = (val: arr[n - 1], pos: n - 1);

            for (int i = n - 2; i >= 0; i--)
            {
                int curr = arr[i];
                int prev = arr[i + 1];
                if (curr > max.val)
                {
                    right[i] += right[max.pos] + (max.pos - i - 1);
                    max.val = curr;
                    max.pos = i;
                }
                else if (curr > prev)
                {
                    right[i] += ++consec;
                }
                else
                {
                    consec = 0;
                }
            }

            var res = new int[n];
            Array.Fill(res, 1);

            for (int i = 0; i < left.Length; i++)
            {
                res[i] = left[i] + right[i] - 1;
            }

            return res;
        }
    }
}
