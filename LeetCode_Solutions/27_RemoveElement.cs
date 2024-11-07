using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class RemoveElement_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int[] newNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    newNums[k] = nums[i];
                    k++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = newNums[i];
            }
            return k;
        }
    }
}
