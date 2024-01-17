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
            int[] myarr = { 14, 12, 9, 2, 4, 10, 11 };

            //BubbleSort.BubbeSortAl(myarr);

            Console.WriteLine(OceanView.FindOceanViewBuildings(myarr));

            Console.ReadLine();

        }

    }
}
