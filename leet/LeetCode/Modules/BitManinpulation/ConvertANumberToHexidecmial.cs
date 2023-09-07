using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BitManinpulation.ConvertANumberToHexidecmial
{
    /*
     * Convert a Number to Hexadecimal
     * 
     * Given an integer num, return a string representing its hexadecimal representation. For negative integers, two’s complement method is used.
     * 
     * All the letters in the answer string should be lowercase characters, and there should not be any leading zeros in the answer except for the zero itself.
     * 
     * https://leetcode.com/explore/learn/card/bit-manipulation/670/bit-manipulation-practice/4256/
     */
    public class Solution
    {
        public string ToHex(int num)
        {
            var sb = new StringBuilder();
            UInt32 unum;

            Console.WriteLine($"Number: {num}.");

            if (num == 0)
            {
                return "0";
            }

            if (num == Int32.MinValue)
            {
                return "80000000";
            }

            if (num < 0)
            {
                unum = UInt32.MaxValue - Convert.ToUInt32(Math.Abs(num)) + 1;
            }
            else
            {
                unum = Convert.ToUInt32(num);
            }

            Console.WriteLine($"Number after conversion: {unum}.");

            while (unum != 0)
            {
                var remainder = ToHexDigit(Math.Abs(unum % 16));

                Console.WriteLine($"Unum: {unum}.  Remainder: {remainder}. String: {sb.ToString()}");

                sb.Insert(0, remainder);
                unum /= 16;
            }

            Console.WriteLine($"Unum: {unum}. String: {sb.ToString()}");

            return sb.ToString();
        }

        private string ToHexDigit(Int64 num)
        {
            if (num < 0 || num > 15)
            {
                throw new IndexOutOfRangeException($"Digit must be between 0 and 15. Digit was {num}");
            }

            if (num < 10)
            {
                return num.ToString();
            }
            else
            {
                // ASCII "a" is 97. So "10" will be 87 + 10 = "a."
                return ((char)(num + 87)).ToString();
            }
        }
    }
}
