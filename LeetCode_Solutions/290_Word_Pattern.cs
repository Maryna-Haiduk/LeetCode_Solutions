using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    /* 290. Word Pattern
     * 
     * Given a pattern and a string s, find if s follows the same pattern.
     * Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
     * 
     * Examples:

        Input: pattern = "abba", s = "dog cat cat dog"
        Output: true

        Input: pattern = "abba", s = "dog cat cat fish"
        Output: false
    */
    internal class _290_Word_Pattern
    {
        public bool WordPattern(string pattern, string s)
        {
            char[] patternKeys = pattern.ToCharArray();
            string[] sValues = s.Split(" ");

            if (patternKeys.Length != sValues.Length)
            {
                return false; // The pattern and string length mismatch.
            }

            Dictionary<char, string> patternToWord = new Dictionary<char, string>();
            Dictionary<string, char> wordToPattern = new Dictionary<string, char>();

            for (int i = 0; i < patternKeys.Length; i++)
            {
                char currentChar = patternKeys[i];
                string currentString = sValues[i];

                if (patternToWord.ContainsKey(currentChar) && patternToWord[currentChar] != currentString)
                {
                    return false;
                }
                else
                {
                    patternToWord[currentChar] = currentString;
                }

                if (wordToPattern.ContainsKey(currentString) && wordToPattern[currentString] != currentChar)
                {
                    return false;
                }
                else
                {
                    wordToPattern[currentString] = currentChar;
                }
            }
           
            
            return true;
        }
    }
}
