using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _912_SortArray
    {
        //912. Sort an Array
        //Medium
        
        // Given an array of integers nums, sort the array in ascending order and return it.

        // You must solve the problem without using any built-in functions in O(nlog(n)) 
        // time complexity and with the smallest space complexity possible.

        public int[] SortArray(int[] nums)
        {
            QuickSort(nums);
            return nums;
        }

        public void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        public void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int i = left;
            int j = right;

            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < pivot)
                    i++;
                while (array[j] > pivot)
                    j--;

                if (i <= j)
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    
                    i++;
                    j--;
                }
            }
            QuickSort(array, i, right);
            QuickSort(array, left, j);
        }
    }
}
