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
            int counter = 0;
            for (int i = 1; i < 16; ++i)
            {
                Console.WriteLine(counter++);
            }

            Console.WriteLine("counter = " + counter);
        }
    }
}
