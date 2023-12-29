using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class ReverseWords
    {
        public static string ReverseWordsMethod(string s)
        {
            var sArray = s.Split(' ');

            var strBuilder = new StringBuilder(s.Length);   

            for (int i = 0; i < sArray.Length; i++) 
            {
                for (int j = sArray[i].Length - 1; j >= 0; j--)
                {
                    strBuilder.Append(sArray[i][j]);    
                }
                if(i < sArray.Length - 1)
                {
                    strBuilder.Append(' ');
                }
            }

            return strBuilder.ToString();   
        }

        public static string ReverseOrderOfWords(string s) 
        {
            var sArray = s.Split(' ');

            var sBuilder = new StringBuilder(s.Length);

            for (int i = sArray.Length - 1; i >= 0; i--)
            {
                sBuilder.Append(sArray[i]);

                if(i > 0)
                {
                    sBuilder = sBuilder.Append(" ");    
                }
            }

            return sBuilder.ToString();    
        }
    }
}
