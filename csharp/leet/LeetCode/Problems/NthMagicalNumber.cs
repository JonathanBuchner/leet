using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.NthMagicalNumber
{
    /*
     * Nth Magical Number
     * 
     * A positive integer is magical if it is divisible by either a or b.
     * 
     * Given the three integers n, a, and b, return the nth magical number. Since the answer may be very large, return it modulo 109 + 7.
     * 
     * https://leetcode.com/problems/nth-magical-number/
     */
    public class Solution
    {
        public int NthMagicalNumber(int n, int a, int b)
        {
            long amount;
            var m = GetMultiplier(a, b, out amount);

            long result = n / m.Count; 
            result *= amount;
            result %= 1000000007;
            result += m[n % m.Count];

            return Convert.ToInt32(result % 1000000007);
        }

        private List<long> GetMultiplier(long a, long b, out long amount)
        {
            long multipleA = a;
            long multipleB = b;
            var list = new List<long>() { 0 } ;

            while (multipleA != multipleB)
            {
                if (multipleA > multipleB)
                {
                    list.Add(multipleB);
                    multipleB += b;
                }
                else
                {
                    list.Add(multipleA);
                    multipleA += a;
                }
            }

            amount = multipleA;

            return list;
        }
    }
}
