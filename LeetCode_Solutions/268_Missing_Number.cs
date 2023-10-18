using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _268_Missing_Number
    {
        /* Given an array nums containing n distinct numbers in the range [0, n], 
         * return the only number in the range that is missing from the array.
         */
        public static int MissingNumber(int[] nums)
        {
            int missingNumber = 0;

            Array.Sort(nums);

            if (nums[0] != 0)
            {
                return missingNumber = 0;
            }
            if (nums[nums.Length - 1] != nums.Length)
            {
                return nums.Length;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return missingNumber = nums[i] - 1;
                }
            }
            return missingNumber;
        }

        public int MissingNumberSecondSolution(int[] nums)
        {
            int missingNumber = 0;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return missingNumber = nums[i] - 1;
                }
            }
            return missingNumber;
        }
    }
}
