﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.StringToInteger
{
    /*
     * String to Integer (ATOI)
     * Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
     * 
     * The algorithm for myAtoi(string s) is as follows:
     *  - Read in and ignore any leading whitespace.
     *  - Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
     *  - Read in next the characters until the next non-digit charcter or the end of the input is reached. The rest of the string is ignored. 
     *  - Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
     *  - If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
     *  - Return the integer as the final result.
     *  
     *  Note:
     *  - Only the space character ' ' is considered a whitespace character.
     *  - Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/171/
     */

    public class Solution
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (String.IsNullOrEmpty(s)) return 0;

            var isNegative = s[0] == '-';
            var startIndex = isNegative || s[0] == '+' ? 1 : 0;

            var i = startIndex;
            while (i < s.Length)
            {
                if (!Char.IsDigit(s[i]))
                {
                    
                    break;
                }

                i++;
            }

            s = s.Substring(startIndex, i - startIndex);
            int result;

            try
            {
                result =  Convert.ToInt32(s);
                if (isNegative) result *= -1;
            }
            
            catch (OverflowException)
            {
                if (isNegative)
                {
                    result = Int32.MinValue;
                }
                else
                {
                    result = Int32.MaxValue;
                }
            }

            catch (FormatException)
            {
                result = 0;
            }

            return result;
        }
    }
}
