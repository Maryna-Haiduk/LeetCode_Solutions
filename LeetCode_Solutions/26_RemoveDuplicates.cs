using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _26_RemoveDuplicates
    {
        /* 26. Remove Duplicates from Sorted Array
        Given an integer array nums sorted in non-decreasing order, 
        remove the duplicates in-place such that each unique element appears only once. 
        The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements 
        in the order they were present in nums initially. 
        The remaining elements of nums are not important as well as the size of nums.

        Return k.
         */
        public int RemoveDuplicates(int[] nums)
        {
            int k = -1;

            var numsList = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (nums[i] != nums[j])
                    {
                        numsList.Add(nums[i]);
                    }
                }
            }

            var newNums = numsList.ToArray();
            k = newNums.Length;

            return k;
        }
    }
}
