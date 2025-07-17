
namespace Leetcode._1_Easy._009_PalindromeNumber
{
    /// <summary>
    /// Provides functionality to determine whether an integer is a palindrome.
    /// </summary>
    /// 
    /// <remarks>
    /// Leetcode Problem: 9. Palindrome Number - Easy
    /// 
    /// Problem: Given an integer x, return true if x is a palindrome, and false otherwise.
    /// 
    /// Example:
    /// 
    /// Input: x = 121 -> Output: true
    /// Input: x = -121 -> Output: false
    /// </remarks>

    internal class Solution
    {
        /// <summary>
        /// Determines whether the input integer is a palindrome by comparing the original and reversed versions.
        /// </summary>
        /// <param name="x">The integer to evaluate.</param>
        /// <returns>
        /// <c>True</c> or <c>False</c> if the input argument is a palindrome number.
        /// </returns>
        public bool IsPalindrome(int x)
        {
            char[] arr = x.ToString().ToArray();
            char[] newArr = new char[arr.Length];

            string param = x.ToString();

            for (int i = arr.Length; i > 0; i--)
            {
                newArr[i - 1] = arr[arr.Length - i];

            }

            string check = new string(newArr);

            if (check == param)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}