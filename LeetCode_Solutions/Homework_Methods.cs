using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class TextHelper
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
        public static bool IsPalindrome(string s) 
        {
            for (int i = 0, j = s.Length -1; i < j ; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        public static void CountVowels(string s)
        {
            Dictionary<char, int> vowels = new Dictionary<char, int>();

            vowels.Add('a', 0);
            vowels.Add('e', 0);
            vowels.Add('o', 0);
            vowels.Add('i', 0);
            vowels.Add('u', 0);

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.ContainsKey(s[i]))
                    vowels[s[i]]++;
            }

            foreach (var kvp in vowels)
            {
                if (kvp.Value != 0)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }

    }
}
