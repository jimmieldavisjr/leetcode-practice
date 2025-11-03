using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1_Easy._387_FirstUniqueCharacterInAString
{
    internal class Solution_1
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }

                else
                {
                    dict[s[i]] += 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }

            Console.WriteLine(-1);
            return -1;
        }
    }
}
