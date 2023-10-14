using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
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
    internal class RemoveDuplicates_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = nums.Length;

            if (k == 0 || k == 1)
                return k;

            int[] temp = new int[k];

            int j = 0;

            for (int i = 0; i < k - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    temp[j++] = nums[i];
                }
            }

            temp[j++] = nums[k - 1];


            for (int i = 0; i < j; i++)
            {
                nums[i] = temp[i];
            }

            k = j;
            return k;
        }
    }
}
