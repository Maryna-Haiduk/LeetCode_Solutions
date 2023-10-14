using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    /*  217. Contains Duplicate

        Given an integer array nums, return true 
        if any value appears at least twice in the array, 
        and return false if every element is distinct.
     */
    internal class _217_Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> uniqueNums = new HashSet<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                uniqueNums.Add(nums[i]);
            }

            if(uniqueNums.Count == nums.Length)
                return false;

            return true;
        }
    }
}
