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
            string myString = "the cattle was rattled by the battery";
            IList<string> list = new List<string>();
            list.Add("catt");
            list.Add("cat");
            list.Add("bat");
            list.Add("rat");

            Console.WriteLine(list);
            Console.WriteLine(_648_Replace_Words.ReplaceWords(list, myString));
        }

    }
}
