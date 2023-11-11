using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _151_ReverseWords
    {
        public static string ReverseWords(string s)
        {
            var words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordsReverse = new List<string>();

            for (int i = words.Length - 1; i >= 0 ; i--)
            {
                wordsReverse.Add(words[i]);
            }

            string result = string.Join(" ", wordsReverse);

            Console.WriteLine(result);   

            return result;
        }
    }
}
