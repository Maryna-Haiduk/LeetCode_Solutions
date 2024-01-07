using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2586_VowelStrings
    {
        /* 2586. Count the Number of Vowel Strings in Range
        You are given a 0-indexed array of string words and two integers left and right.
        A string is called a vowel string if it starts with a vowel character and ends with a vowel 
        character where vowel characters are 'a', 'e', 'i', 'o', and 'u'.
        Return the number of vowel strings words[i] where i belongs to the inclusive range [left, right].
        */

        public int VowelStrings(string[] words, int left, int right)
        {
            int vowelWordsCount = 0;

            for (int i = left; i <= right; i++)
            {
                if (words[i][0] == 'a' |
                    words[i][0] == 'e' |
                    words[i][0] == 'i' |
                    words[i][0] == 'o' |
                    words[i][0] == 'u' &&
                    words[i].Length - 1 == 'a' |
                    words[i].Length - 1 == 'e' |
                    words[i].Length - 1 == 'i' |
                    words[i].Length - 1 == 'o' |
                    words[i].Length - 1 == 'u')

                {
                    vowelWordsCount++;
                }
            }

            return vowelWordsCount;
        }
    }
}
