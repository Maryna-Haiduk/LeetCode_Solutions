using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _189_RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {

            for (int i = 0; i < k; i++)
            {
                int tmp = nums[nums.Length - 1];

                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = tmp;
            }
        }
    }
}
