
namespace Leetcode._1_Easy._009_PalindromeNumber
{
    internal class Solution
    {
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
                Console.WriteLine($"True. Parameter: {param} is a palindrome of {check}");
                return true;
            }

            else
            {
                Console.WriteLine($"False. Parameter: {param} is not a palindrome of {check}");
                return false;
            }
        }
    }
}