using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputString = "hello";

            var newString = ReverseString.GetRverseString(inputString);
            Console.WriteLine(newString);
        }
    }
}
