using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2089_TargetIndices
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            // QuickSort(nums);
            Array.Sort(nums);
            IList<int> resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    resultList.Add(i);
                }
            }
            return resultList;
        }

        //public void QuickSort(int[] array)
        //{
        //    QuickSort(array, 0, array.Length - 1);
        //}

        //public void QuickSort(int[] array, int left, int right)
        //{
        //    if (left >= right)
        //        return;

        //    int i = left;
        //    int j = right;

        //    int pivot = array[(left + right) / 2];

        //    while (i <= j)
        //    {
        //        while (array[i] < pivot)
        //            i++;
        //        while (array[j] > pivot)
        //            j--;

        //        if (i <= j)
        //        {
        //            int tmp = array[i];
        //            array[i] = array[j];
        //            array[j] = tmp;
                
        //            i++;
        //            j--;
        //        }

        //        QuickSort(array, left, j);
        //        QuickSort(array, i, right);
        //    }

        //}
    }
}
