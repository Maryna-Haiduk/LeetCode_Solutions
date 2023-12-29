using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2710_Remove_Trailing_Zeros_From_a_String
    {
        // 2710. Remove Trailing Zeros From a String
        public static string RemoveTrailingZeros(string num)
        {
            var strBuilder = new StringBuilder(num);  
            
            for (int i = num.Length - 1; i >=0 ; i--)
            {
                if (num[i] != '0')
                {
                    break;
                }
                else if (num[i] == '0')
                {
                    strBuilder.Remove(i, 1); 
                }
            }

            return strBuilder.ToString();
        }
    }
}
