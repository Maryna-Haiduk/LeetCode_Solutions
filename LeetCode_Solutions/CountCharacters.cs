using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class CountCharacters
    {
        public static void CountEachCharacters(string s)
        {
            var dic = new Dictionary<char, int>();
            
            foreach (char c in s) 
            {
                if (c == ' ')
                    continue;

                if(dic.ContainsKey(c)) 
                {
                    dic[c] += 1;    
                }
                else
                {
                    dic.Add(c, 1);
                }

            }

            foreach (var v in dic)
            {
                Console.WriteLine(v);
            }
        }
    }
}
