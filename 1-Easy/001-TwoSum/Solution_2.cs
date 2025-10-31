using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1_Easy._001_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int key = target - nums[i];

                if (seen.TryGetValue(key, out int index))
                {
                    return new[] { index, i };
                }

                else
                {
                    seen[nums[i]] = i;
                }
            }
            return new int[] { };
        }
    }
}
