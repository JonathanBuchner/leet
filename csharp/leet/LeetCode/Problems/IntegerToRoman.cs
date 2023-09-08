using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.IntegerToRoman
{
    /*
     * Integer to Roman
     * 
     * Given an integer, convert it to a roman numeral.
     * 
     * https://leetcode.com/problems/integer-to-roman/
     */
    public class Solution
    {
        public string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            if (num >= 1000)
            {
                var mAdditions = num / 1000;
                sb.Append('M', mAdditions);
                num -= mAdditions * 1000;
            }

            if (num >= 900)
            {
                sb.Append("CM");
                num -= 900;
            }

            if (num >= 500)
            {

                sb.Append('D');
                num -= 500;
            }
            if (num >= 400)
            {
                sb.Append("CD");
                num -= 400;
            }

            if (num >= 100)
            {
                var count = num / 100;

                sb.Append('C', count);
                num -= count * 100;
            }
            if (num >= 90)
            {
                sb.Append("XC");
                num -= 90;
            }

            if (num >= 50)
            {
                sb.Append('L');
                num -= 50;
            }
            if (num >= 40)
            {
                sb.Append("XL");
                num -= 40;
            }

            if (num >= 10)
            {
                var count = num / 10;

                sb.Append('X', count);
                num -= count * 10;
            }
            if (num == 9)
            {
                sb.Append("IX");
                num -= 9;
            }

            if (num >= 5)
            {
                sb.Append('V');
                num -= 5;
            }
            if (num == 4)
            {
                sb.Append("IV");
                num -= 4;
            }

            if (num >= 1)
            {
                sb.Append('I', num);
            }

            return sb.ToString();
        }
    }
}
