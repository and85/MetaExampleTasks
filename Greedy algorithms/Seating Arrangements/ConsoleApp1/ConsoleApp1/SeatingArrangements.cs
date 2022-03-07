using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{        
    public class SeatingArrangements
    {
        public static int minOverallAwkwardness(int[] arr)
        {
            Array.Sort(arr);
            int max = int.MinValue, dif;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i - 2 < 0)
                {
                    dif = Math.Abs(arr[i] - arr[i - 1]);
                }
                else if (i == arr.Length - 1)
                {
                    dif = Math.Max(Math.Abs(arr[i] - arr[i - 2]), Math.Abs(arr[i] - arr[i - 1]));
                }
                else
                {
                    dif = Math.Abs(arr[i] - arr[i - 2]);
                }

                max = Math.Max(max, dif);
            }

            return max;
        }
    }
}
