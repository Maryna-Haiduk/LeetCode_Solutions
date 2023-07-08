using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2540_Minimum_Common_Value
    {
        /* 2540. Minimum Common Value
         
           Given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
           return the minimum integer common to both arrays. If there is no common integer amongst nums1 and nums2, return -1.

           Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.

        1) відсортувати масиви
        2) помістити один масив у цикл фор
        3) знайти перше спільне число між двома масивами 
        (ітерація циклу першого масиву буде ціллю, яку ми шукатимемо у другому масиві бінарним пошуком)
        */

        public int GetCommon(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                int left = 0;
                int right = nums2.Length - 1;

                if (nums1[i] == nums2[left])
                {
                    return nums1[i];
                }
                if (nums1[i] == nums2[right])
                {
                    return nums1[i];
                }

                while (left <= right)
                {
                    int midl = (left + right) / 2;

                    if (nums1[i] == nums2[midl])

                    {
                        return nums1[i];
                    }

                    else if (nums1[i] < nums2[midl])
                    {
                        right = midl - 1;
                    }
                    else if (nums1[i] > nums2[midl])
                    {
                        left = midl + 1;
                    }
                }
            }
            return -1;
        }
    }
}
