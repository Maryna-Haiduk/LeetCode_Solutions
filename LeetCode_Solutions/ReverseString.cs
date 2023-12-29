using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class ReverseString
    {   

        public static string GetRverseString(string s) 
        {
            char[] chars = s.ToCharArray();

            char[] reverseString = new char[chars.Length];

            int k = 0;

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reverseString[k] = chars[i];
                k++;
            }

            string result = new string(reverseString);

            return result;
        }

        public static void ReverseStringMethod(char[] s)
        {
            int k = 0;

            for (int i = s.Length - 1; i >= s.Length/2; i--)
            {
                char tmp = s[k];
                s[k] = s[i];
                s[i] = tmp;
                k++;
            }
        }

        public static void ReverseStringMethodSecond(char[] s)
        {

            for (int i = s.Length - 1, k = 0; i > k; i--, k++)
            {
                char tmp = s[k];
                s[k] = s[i];
                s[i] = tmp;
            }
        }

        public static string ReverseStringThird(string s)
        {
            var strBuilder = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(s[i]);
            }

            return strBuilder.ToString();
        }
    }
}
