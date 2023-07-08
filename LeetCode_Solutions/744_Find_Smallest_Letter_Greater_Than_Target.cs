using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class Find_Smallest_Letter_Greater_Than_Target_744
    {
        /*744. Find Smallest Letter Greater Than Target
          
        You are given an array of characters letters that is sorted in non-decreasing order, 
        and a character target. There are at least two different characters in letters.

        Return the smallest character in letters that is lexicographically greater than target. 
        If such a character does not exist, return the first character in letters.
 
        1) пройтись по масиву і порівняти з ціллю
        2) викинути скіпнути всі буки менші або рівні за ціль
        3) перша більша за ціль буква попадає в поверення 
         */

        public char NextGreatestLetter(char[] letters, char target)
        {
            Array.Sort(letters);

            for (int i = 0; i < letters.Length; i++)
            {
                if(letters[i] > target)
                {
                    return letters[i];
                    break;
                }
            }
            return letters[0];
        }

        //public char NextGreatestLetterBinary(char[] letters, char target)
        //{
        //    Array.Sort(letters);

        //    int left = 0;
        //    int right = letters.Length - 1;

        //    if (letters[0] == target)
        //    { return letters[1]; }

        //    else if (letters[right] == target)
        //    { return letters[0]; }

        //    while (left <= right)
        //    {
        //        int midle = (left + right) / 2;

        //        if (letters[midle] == target)
        //        {
        //            midle += 1;
        //            return letters[midle]; 
        //        }

        //        else if (target < letters[midle])
        //        {
        //            right = midle - 1;
        //        }
        //        else if (target > letters[midle])
        //        {
        //            left = midle + 1;
        //        }
        //    }

        //    return letters[0];
        //}
    }
}
