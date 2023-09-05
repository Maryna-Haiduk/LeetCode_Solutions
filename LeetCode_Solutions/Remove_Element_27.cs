using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    /* 27. Remove Element
     * 
    Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
    The order of the elements may be changed. 
    Then return the number of elements in nums which are not equal to val.

    Consider the number of elements in nums which are not equal to val be k, 
    to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums 
    contain the elements which are not equal to val. 
    The remaining elements of nums are not important as well as the size of nums.
    Return k.
     */
    internal class Remove_Element_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = nums.Length;
            int countVal = 0;

            for (int i = 0; i < k; i++)
            {
                if (nums[i] == val)
                {
                    countVal++;
                }
                else
                {
                    nums[i - countVal] = nums[i];
                }
            }

            k -= countVal;
            return k;
        }
    }
}
