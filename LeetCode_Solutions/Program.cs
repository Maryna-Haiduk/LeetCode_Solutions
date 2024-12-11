using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 3, 3 };
            int result = BestTimeToBuyAndSellStock_121.MaxProfit2(myArray);
            Console.WriteLine(result);
        }

    }
}
