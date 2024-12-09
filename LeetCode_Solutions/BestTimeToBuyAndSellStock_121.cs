using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class BestTimeToBuyAndSellStock_121
    {
        public static int MaxProfit1(int[] prices)
        {
            int maxProfit = 0;
            int left = 0;
            int right = 1;

            while (left < right && left < prices.Length - 1) 
            {
                if(right < prices.Length) 
                {
                    if (prices[left] < prices[right])
                    {
                        int pofit = prices[right] - prices[left];
                        if (pofit > maxProfit)
                        {
                            maxProfit = pofit;
                        }
                        right++;
                    }
                    else
                    {
                        left++;
                        right++;
                    }
                }
                else
                {
                    right = left + 1;
                }
                
            }
            
            return maxProfit;
        }
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length - 1; j++)
                {
                    if (prices[j] < prices[i])
                    {
                        continue;
                    }
                    else
                    {
                        int profit = prices[j] - prices[i];
                        if (profit > maxProfit)
                        {
                            maxProfit = profit;
                        }
                    }
                }
            }
            return maxProfit;
        }
    }
}
