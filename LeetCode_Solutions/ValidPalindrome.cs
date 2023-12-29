using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            bool result = true;

            s = s.ToLower();
            s = s.Trim();
            //s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);
            s = string.Concat(s.Where(c => Char.IsLetterOrDigit(c)));

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                { result = false; break; }
            }

            return result;
        }
    }
}
