using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class CountCharacter
    {
        /*Q.5: How to count the occurrence of each character in a string?
        Ans.: The user will input a string and we need to find the count of each character 
        of the string and display it on console.We won’t be counting space character.
        */

        public static void CountCharacters(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str) 
            {
                if(c != ' ')
                {
                    if (dict.ContainsKey(c))
                    {
                        dict[c]++;
                    }
                    else
                    {
                        dict[c] = 1;
                    }
                }                
            }

            foreach (var v in dict) 
            {
                Console.WriteLine($"{v.Key} - {v.Value}");
            }
        }
    }
}
