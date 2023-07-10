using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2418_Sort_the_People
    {
        /*
        2418. Sort the People
        You are given an array of strings names, and an array heights that consists of distinct positive integers. 
        Both arrays are of length n.
        For each index i, names[i] and heights[i] denote the name and height of the ith person.
        Return names sorted in descending order by the people's heights.
         */
        public string[] SortPeople(string[] names, int[] heights)
        {
            for (int i = 0; i < heights.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (heights[j] > heights[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = heights[maxIndex];
                heights[maxIndex] = heights[i];
                heights[i] = temp;

                string tempString = names[maxIndex];
                names[maxIndex] = names[i];
                names[i] = tempString;
            }
            return names;
        }
    }
}
