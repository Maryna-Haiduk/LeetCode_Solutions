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
            string str1 = "alex maryna g four";
            string str2 = "alexela";

            Console.WriteLine(Homework_Methods.IsPalindrom(str1));
            Console.WriteLine(Homework_Methods.IsPalindrom(str2));

            Console.ReadLine();

        }

    }
}
