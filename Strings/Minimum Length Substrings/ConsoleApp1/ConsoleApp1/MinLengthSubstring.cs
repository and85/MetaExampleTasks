using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinLengthSubstring
    {
        public int minLengthSubstring(String s, String t)
        {
            int minLength = int.MaxValue;
            var dictT = t.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            int l = 0, r = 0;
            string window;

            while (r <= s.Length)
            {
                window = s.Substring(l, r - l);
                if (IsValidWindow(window, dictT))
                {
                    minLength = Math.Min(minLength, window.Length);
                    l++;
                }
                else
                {
                    r++;
                }
            }

            return minLength != int.MaxValue ? minLength : -1;
        }

        private bool IsValidWindow(string window, Dictionary<char, int> dictT)
        {
            bool isValid = true;
            var dictCopy = new Dictionary<char, int>(dictT);

            for (int i = 0; i < window.Length; i++)
            {
                if (dictCopy.ContainsKey(window[i]))
                {
                    dictCopy[window[i]]--;
                }
            }

            return dictCopy.Values.All(v => v <= 0);
        }        
    }
}
