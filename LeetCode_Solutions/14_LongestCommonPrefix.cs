using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0 || string.IsNullOrEmpty(strs[0]))
            {
                return "";
            }

            List<char> prefixList = new List<char>();

            for (int i = 0; i < strs[0].Length; i++)
            {
                char current = strs[0][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != current)
                    {
                        return new string(prefixList.ToArray());
                    }
                    if (j == strs.Length - 1)
                    {
                        prefixList.Add(current);
                    }
                }
            }

            string commonPrefix = new string(prefixList.ToArray());

            if (commonPrefix.Length > 0)
                return commonPrefix;

            return "";
        }
    }
}
