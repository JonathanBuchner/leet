using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.StrobogrammaticNumber
{
    /*
     * Strobogrammatic Number
     * 
     * Given a string num which represents an integer, return true if num is a strobogrammatic number.  A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).
     * 
     * https://leetcode.com/problems/strobogrammatic-number/
     */
    public class Solution
    {
        public bool IsStrobogrammatic(string num)
        {
            var p1 = 0;
            var p2 = num.Length - 1;

            while (p1 < p2)
            {
                if (
                    num[p1] == '6' && num[p2] == '9' ||
                    num[p1] == '9' && num[p2] == '6' ||
                    num[p1] == '8' && num[p2] == '8' ||
                    num[p1] == '1' && num[p2] == '1' ||
                    num[p1] == '0' && num[p2] == '0'
                )
                {
                    p1++;
                    p2--;
                }
                else
                {
                    return false;
                }
            }

            if (p1 == p2)
            {
                if (
                    num[p1] == '8' && num[p2] == '8' ||
                    num[p1] == '1' && num[p2] == '1' ||
                    num[p1] == '0' && num[p2] == '0'
                )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
