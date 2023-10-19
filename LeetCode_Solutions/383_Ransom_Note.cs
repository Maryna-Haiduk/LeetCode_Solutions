using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _383_Ransom_Note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            Dictionary<char, int> magazineDictionary = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if(magazineDictionary.ContainsKey(c))
                {
                    magazineDictionary[c]++;
                }
                else
                {
                    magazineDictionary.Add(c, 1);
                }
            }


            foreach (char c in ransomNote)
            {
                if (magazineDictionary.ContainsKey(c) && magazineDictionary[c] > 0)
                {
                    magazineDictionary[c]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
