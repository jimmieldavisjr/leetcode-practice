using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1_Easy._217_ContainsDuplicate
{
    internal class Solution_1
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return true;
                }

                else
                {
                    dict[nums[i]] = i;
                }
            }

            return false;
        }
    }
}