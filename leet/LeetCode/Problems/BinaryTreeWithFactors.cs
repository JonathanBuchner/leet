using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreeWithFactors
{
    /*
     * 823. Binary Trees With Factors
     * 
     * Given an array of unique integers, arr, where each integer arr[i] is strictly greater than 1.
     * 
     * https://leetcode.com/problems/binary-trees-with-factors/
     */
    public class Solution
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            var dp = new int[arr.Length];
            var dict = new Dictionary<int, int>();
            int mod = 100000000;
            Array.Sort(arr);

            for(var i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], i);
                dp[i] = 1;
            }

            for(var i = 0; i < arr.Length; i++)
            {
                for(var k = i; k < arr.Length; k++)
                {
                    var total = arr[i] * arr[k];

                    if(total > arr[arr.Length] - 1)
                    {
                        break;
                    }

                    if(dict.ContainsKey(total))
                    {
                        if(k == i)
                        {
                            arr[total] += dp[i];
                        }
                        else
                        {
                            arr[total] += dp[i] * dp[k];
                        }
                    }
                }
            }

            return (int) dp.Sum() % mod;
        }
    }
}
