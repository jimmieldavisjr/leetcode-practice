using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1_Easy._771_JewelsAndStones
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int result = 0;

            foreach (char c in jewels)
            {
                dict[c] = 0;
            }

            for (int i = 0; i < stones.Length; i++)
            {
                if (dict.ContainsKey(stones[i]))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
