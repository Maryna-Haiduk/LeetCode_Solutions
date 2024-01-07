using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class Homework_Methods
    { 
        // to count the number of words in a string that have more than 4 letters
        public static int HasMoreFourLetters(string s)
        {
            var words = s.Split(' ');
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 4)
                    count++;
            }

            return count;
        }

        // to check if a string is a palindrome
        public static bool IsPalindrom(string s) 
        {
            for (int i = 0, j = s.Length -1; i < j ; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

    }
}
