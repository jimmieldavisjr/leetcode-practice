namespace Leetcode
{
    /// <summary>
    /// Provides functionality for locating two indices in an integer array whose values sum to a target number.
    /// </summary>
    /// 
    /// <remarks>
    /// Leetcode Problem: 1. Two Sum — Easy
    /// 
    /// Problem: Given an array of integers <c>nums</c> and an integer <c>target</c>, return indices 
    /// of the two numbers such that they add up to <c>target</c>.
    /// You may assume that each input has exactly one solution, and 
    /// you may not use the same element twice.
    /// 
    /// Example:
    /// 
    /// Input: nums = [2, 7, 11, 15], target = 9  
    /// Output: [0, 1]
    /// </remarks>
    internal class Solution
    {
        /// <summary>
        /// Finds two indices in the input array whose corresponding values sum to the specified target.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <param name="target">The target integer to find as the sum of two elements from <paramref name="nums"/>.</param>
        /// <returns>
        /// An integer array containing the indices of the two elements that sum to <paramref name="target"/>.
        /// </returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
