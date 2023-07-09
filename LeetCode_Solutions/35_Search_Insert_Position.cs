using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _35_Search_Insert_Position
    {
        /* 35. Search Insert Position
         * 
        Given a sorted array of distinct integers and a target value, return the index if the target is found. 
        If not, return the index where it would be if it were inserted in order.

        You must write an algorithm with O(log n) runtime complexity.
        *
        */

        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;   

                if(target == nums[mid])
                    return mid;

                if (target < nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
