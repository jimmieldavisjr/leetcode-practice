using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1_Easy._290_WordPattern
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string[] words = s.Split(' ');

            if (words.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != words[i])
                    {
                        return false;
                    }

                    else
                    {
                        dict[pattern[i]] = words[i];
                    }
                }

                else if (!dict.ContainsKey(pattern[i]) && dict.ContainsValue(words[i]))
                {
                    return false;
                }

                else
                {
                    dict[pattern[i]] = words[i];
                }
            }

            return true;
        }
    }
}