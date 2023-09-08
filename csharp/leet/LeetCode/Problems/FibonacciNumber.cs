using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FibonacciNumber
{
    /*
     * Fibonacci Number
     * 
     * Given n, calculate F(n).
     * 
     * https://leetcode.com/problems/fibonacci-number/
     * 
     * Link to https://demonstrations.wolfram.com/GeneralizedFibonacciSequenceAndTheGoldenRatio/
     */
    public class Solution
    {
        public int Fib(int n)
        {
            return (int)Math.Round(Math.Pow((1 + Math.Sqrt(5)) / 2, n) / Math.Sqrt(5));
        }
    }
}
