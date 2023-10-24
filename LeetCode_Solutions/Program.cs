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
            string s = "badc";
            string t = "baba";

            bool result = _205_Isomorphic_Strings.IsIsomorphic(s, t);
            Console.WriteLine(result);
    }
    }
}
