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
            int num = 19;
            bool isHappy = _202_Happy_Number.IsHappy(num);

            Console.WriteLine(isHappy);
        }
    }
}
