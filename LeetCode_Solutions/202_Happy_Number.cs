using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _202_Happy_Number
    {
        /*202. Happy Number
        Write an algorithm to determine if a number n is happy.

        A happy number is a number defined by the following process:

        Starting with any positive integer, replace the number by the sum of the squares of its digits.
        Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        Those numbers for which this process ends in 1 are happy.
        Return true if n is a happy number, and false if not.
                Example 1:

        Input: n = 19
        Output: true
        Explanation:
        12 + 92 = 82
        82 + 22 = 68
        62 + 82 = 100
        12 + 02 + 02 = 1
        */

        public static bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            return IsHappyRecursive(n, seen);
        }
        public static bool IsHappyRecursive(int n, HashSet<int> seen)
        {
            if (n == 1) return true;
            else if (seen.Contains(n)) return false;

            seen.Add(n);

            var digits = IntToDigitsArray(n);
            int squaresResult = SumOfSquares(digits);

            return IsHappyRecursive(squaresResult, seen);

        }

        public static int[] IntToDigitsArray(int number)
        {
            string stingNum = number.ToString();
            var numbersCharArray = stingNum.ToCharArray();

            List<int> numbersList = new List<int>();

            foreach (var digitChar in numbersCharArray)
            {
                int digit = (int)(digitChar - '0');
                numbersList.Add(digit);
            }

            var digits = numbersList.ToArray();

            return digits;
        }


        public static int SumOfSquares(int[] digits)
        {
            int squaresResult = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] *= digits[i];
                squaresResult += digits[i];
            }

            return squaresResult;
        }
    }
}
