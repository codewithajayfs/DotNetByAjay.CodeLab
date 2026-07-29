using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.CSharpProgram
{
    public static class StringExtension
    {
        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                // Optional: Ignore case by converting to lowercase or using char.ToLower()
                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}