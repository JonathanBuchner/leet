using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.KInversePairsArray
{
    /*
     * K Inverse Pairs Array
     * 
     * For an integer array nums, an inverse pair is a pair of integers [i, j] where 0 <= i < j < nums.length and nums[i] > nums[j]. Given two integers n and k, return the number of different arrays consist of numbers from 1 to n such that there are exactly k inverse pairs. Since the answer can be huge, return it modulo 109 + 7.
     * 
     * https://leetcode.com/problems/k-inverse-pairs-array/
     */
    public class Solution
    {
        public int KInversePairs(int n, int k)
        {
            var mod = 1000000007;
            var dp = new int[k + 1];
            
            for(var i = 1; i <= n; ++i)
            {
                var temp = new int[dp.Length];
                temp[0] = 1;

                for(var l = 1; l <= k; l++)
                {
                    var end = k - i >= 0 ? dp[l - i] : 0;
                    temp[l] = dp[l] + temp[l - 1] - end; 
                }

                dp = temp;
            }

            return dp[k];
        }
    }
}
