using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class LongestPalindrome_5
    {
        // Given a string s, return the longest palindromic substring in s
        public static string LongestPalindrome(string s)
        {
            if(s.Length <= 1)
            {
                return s;
            }
            string longestPalindrome = "";

            List<string> palindromicSubstrings = new List<string>();

            string temp = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > i; j--)
                {
                    if (s[i] == s[j])
                    {
                        temp = s.Substring(i, (j - i) + 1);
                        
                        bool isPalindrome = IsStringPalindrome(temp);
                        
                        if(isPalindrome == true)
                        {
                            palindromicSubstrings.Add(temp);
                        }
                    }
                }
            }

            int longest = 0;

            foreach (string pal in palindromicSubstrings)
            {
                if (pal.Length > longest)
                {
                    longest = pal.Length;
                    longestPalindrome = pal;
                }
            }

            return longestPalindrome;
        }

        public static bool IsStringPalindrome(string str)
        {
            bool result = true;

            if (str == null || str.Length == 0)
            {
                result = false;
            }

            for (int i = 0, j = str.Length - 1; i < str.Length / 2 & j >= str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
