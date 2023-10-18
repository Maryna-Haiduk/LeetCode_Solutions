using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _58_Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            int lastWordLength = 0;
            
            string[] array = s.Split(" ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(array[i]))
                { 
                    continue; 
                }
                else
                {
                    return lastWordLength = array[i].Length;
                }
            }
            return lastWordLength;
        }

        public int LengthOfLastWordSecondSolution(string s)
        {
            int lastWordLength = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (lastWordLength == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return lastWordLength;
                    }
                }
                
                lastWordLength++;
            }
            return lastWordLength;
        }

        public int LengthOfLastWordThirdSolution(string s)
        {
            return s.Split(' ').Where(x => !string.IsNullOrEmpty(x)).Last().Length;
        }
    }
}
