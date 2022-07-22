using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.PluseOne
{
    /*
     * Plus One
     * 
     * You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's. Increment the large integer by one and return the resulting array of digits.
     * 
     * https://leetcode.com/problems/plus-one/
     */
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            var add = true;
            var i = digits.Length - 1;

            while (add && i >= 0)
            {
                ++digits[i];

                if (digits[i] == 10)
                {
                    digits[i] = 0;
                }
                else
                {
                    add = false;
                }

                i--;
            }

            if (add && i == -1)
            {
                var result = new int[digits.Length + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digits.Length);

                return result;
            }
            else
            {
                return digits;
            }
        }
    }
}
