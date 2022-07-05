using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ClimbingStairs
{
    /*
     * Climbing Stairs
     * 
     * You are climbing a staircase. It takes n steps to reach the top.  Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
     * 
     * https://leetcode.com/problems/climbing-stairs/
     */
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            var steps = n < 3 ? new int[3] : new int[n + 1];
            steps[0] = 0;
            steps[1] = 1;
            steps[2] = 2;

            for (var i = 3; i < steps.Length; i++)
            {
                steps[i] = steps[i - 1] + steps[i - 2];
            }

            return steps[n];
        }
    }
}
