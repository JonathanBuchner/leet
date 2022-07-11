using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinCostCLimbingStairs
{
    /*
     * Min Cost Climbing Stairs
     * 
     * You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps
     * 
     * https://leetcode.com/problems/min-cost-climbing-stairs/
     */
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if(cost.Length == 0)
            {
                return 0;
            }

            if(cost.Length == 1)
            {
                return cost[0];
            }

            for(var i = 2; i < cost.Length; ++i)
            {
                cost[i] += cost[i - 2] < cost[i - 1] ?
                    cost[i - 2] :
                    cost[i - 1];
            }

            return cost[cost.Length - 2] < cost[cost.Length - 1] ?
                cost[cost.Length - 2] :
                cost[cost.Length - 1]; 
        }
    }
}
