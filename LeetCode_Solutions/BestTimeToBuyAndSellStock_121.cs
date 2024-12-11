using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class BestTimeToBuyAndSellStock_121
    {
        public static int MaxProfit2(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    if ((i == prices.Length - 1 && prices[i] >= minPrice) || (prices[i] > prices[i + 1]))
                    {
                        int profit = prices[i] - minPrice;
                        maxProfit += profit;
                        minPrice = int.MaxValue;
                    }
                }
            }
            return maxProfit;
        }
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
            int minPrice = int.MaxValue;

            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }

                if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
