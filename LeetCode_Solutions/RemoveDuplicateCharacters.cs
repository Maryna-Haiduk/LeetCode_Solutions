using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class RemoveDuplicateCharacters
    {
        // How to remove duplicate characters from a string?

        public static string RemoveDuplicate(string s)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            var newString = string.Concat(set);
            return newString;
        }

        public static string RemoveDupliates(string s) 
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            
            for (int i = 0; i < s.Length; i++)
            {
                uniqueChars.Add(s[i]);
            }

            string uniqueString = string.Concat(uniqueChars);   
            return uniqueString;

        }
    }
}
