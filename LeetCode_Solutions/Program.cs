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
            var letters = new[] { 'a', 'b', 'c', 'd', 'e' };
            char target = 'a';

            NextGreatestLetter(letters, target);
        }
        public static char NextGreatestLetter(char[] letters, char target)
        {
            Array.Sort(letters);

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > target)
                {
                    return letters[i];
                    break;
                }
            }
            return letters[0];
        }
    }
}
