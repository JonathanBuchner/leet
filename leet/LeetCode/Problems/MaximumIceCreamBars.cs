using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaximumIceCreamBars
{
    /*
     * Maximum Ice Cream Bars
     * 
     * It is a sweltering summer day, and a boy wants to buy some ice cream bars. At the store, there are n ice cream bars. You are given an array costs of length n, where costs[i] is the price of the ith ice cream bar in coins. The boy initially has coins coins to spend, and he wants to buy as many ice cream bars as possible. 
     * 
     * Return the maximum number of ice cream bars the boy can buy with coins coins.
     * 
     * Note: The boy can buy the ice cream bars in any order.
     * 
     * https://leetcode.com/problems/maximum-ice-cream-bars/description/
     */
    public class Solution
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs, (a, b) => a.CompareTo(b));

            var i = 0;
            while (i < costs.Length && costs[i] <= coins)
            {
                coins -= costs[i];
                i++;
            }

            return i;
        }
    }
}
