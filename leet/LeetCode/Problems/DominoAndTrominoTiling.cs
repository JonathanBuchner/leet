using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.DominoAndTrominoTiling
{
    /*
     * Domino and Tromino Tiling
     * 
     * You have two types of tiles: a 2 x 1 domino shape and a tromino shape. You may rotate these shapes. Given an integer n, return the number of ways to tile an 2 x n board. Since the answer may be very large, return it modulo 10^9 + 7 (1000000007).
     * 
     * https://leetcode.com/problems/domino-and-tromino-tiling/
     */
    public class Solution
    {
        public int NumTilings(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            long curr = 2;
            long prev = 1;
            long preTri = 1;
                
            for (int i = 0; i < n - 2; i++)
            {
                var temp = curr + prev + 2 * preTri;
                preTri = preTri + prev;
                prev = curr;
                curr = temp % 1000000007;
            }

            return (int)curr;
        }
    }
}
