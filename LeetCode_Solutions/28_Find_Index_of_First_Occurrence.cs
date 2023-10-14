using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    /* 28. Find the Index of the First Occurrence in a String
     * Given two strings needle and haystack, 
    return the index of the first occurrence of needle in haystack, 
    or -1 if needle is not part of haystack.

    Example 1:

    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
    Explanation: "sad" occurs at index 0 and 6.
    The first occurrence is at index 0, so we return 0.
    */
    internal class _28_Find_Index_of_First_Occurrence
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length)
                    return i;
            }
            return -1;
        }
    }
}
