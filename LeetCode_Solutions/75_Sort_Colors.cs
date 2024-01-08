using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _75_Sort_Colors
    {
        /*75. Sort Colors

        Given an array nums with n objects colored red, white, or blue, 
        sort them in-place so that objects of the same color are adjacent, 
        with the colors in the order red, white, and blue.

        We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

        You must solve this problem without using the library's sort function.
 
         */
        public class Solution
        {
            public void SortColors(int[] nums)
            {
                bool isDane = true;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 1; j < nums.Length; j++)
                    {
                        if (nums[j] < nums[j - 1] || nums[j] == nums[j - 1])
                        {
                            int tmp = nums[j];
                            nums[j] = nums[j - 1];
                            nums[j - 1] = tmp;
                            isDane = false;
                        }
                    }
                    if (isDane)
                        break;
                }
            }
        }
    }
}
