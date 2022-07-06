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
     */
    public class Solution
    {
        public int Fib(int n)
        {
            var arr = new int[n + 1];

            if (n == 0)
            {
                return 0;
            }

            arr[0] = 0;
            arr[1] = 1;

            for (var i = 2; i <= n; ++i)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }
    }
}
