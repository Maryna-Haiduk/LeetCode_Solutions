using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> numsCounter = new Dictionary<int, int>();    

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsCounter.ContainsKey(nums[i]))
                {
                    numsCounter[nums[i]]++;
                }
                else
                {
                    numsCounter.Add(nums[i], 1);
                }
            }

            int count = 0;

            foreach (var v in nums)
            {
                if (numsCounter[v] > count)
                {
                    count = numsCounter[v];
                }
            }

            var myKey = numsCounter.FirstOrDefault(x => x.Value == count).Key;
            
            return myKey;
        }
    }
}
