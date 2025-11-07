using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._2_Medium._3_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            int left = 0;
            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict[s[i]] = i;
                }

                else
                {
                    res = Math.Max(res, dict.Count());

                    while (dict.ContainsKey(s[i]))
                    {
                        dict.Remove(s[left]);
                        left++;
                    }

                    dict[s[i]] = i;
                }
            }
            return Math.Max(res, dict.Count());
        }
    }
}
