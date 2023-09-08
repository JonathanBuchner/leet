using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.AddDigits
{
    /*
     * Add digits
     * 
     * Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
     * 
     * https://leetcode.com/problems/add-digits/description/
     */
    public class Solution
    {
        public int AddDigits(int num)
        {
            var total = 0;

            while (num >= 1)
            {
                total += num % 10;
                num /= 10;
            }

            if (total > 9)
            {
                total = AddDigits(total);
            }

            return total;
        }
    }
}

