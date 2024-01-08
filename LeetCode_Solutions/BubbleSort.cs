using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class BubbleSort
    {
        public static void BubbeSortAl(int[] array)
        {
            bool isDone = true;

            for (int i = 0; i < array.Length; i++)
            {
                isDone = true;
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1] || array[j] == array[j - 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                        isDone = false;
                    }
                }
                if (isDone)
                    break;
            }
        }

            //int i = 0;

            //while (i + 1 < array.Length - 1) 
            //{
            //    if(array[i] > array[i + 1])
            //    {
            //        int tmp = array[i];
            //        array[i + 1] = array[i];
            //        array[i] = tmp;
            //    }
                    
            //    i++;
            //}
        
    }
}
