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
            string str1 = "alex maryna";
            int[] myarr = { 4, 9, 2, 4 };

            BubbleSort.BubbeSortAl(myarr);

            foreach (int i in myarr) 
            {
                Console.WriteLine(i);   
            }

            Console.ReadLine();

        }

    }
}
