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
        StringBuilder sb = new StringBuilder();
        public string IntToRoman(int num)
        {
            

            while (num >= 1000)
            {
                sb.Append("M");
                num -= 1000;
            }

            var hundreds = num / 100 % 10;
            var tens = num / 10 % 10;
            var ones = num % 10;

            Converter(hundreds, 'C', 'D', 'M');
            Converter(tens, 'X', 'L', 'C');
            Converter(ones, 'I', 'V', 'X');

            return sb.ToString();
        }

        private void Converter(int num, char first, char five, char ten)
        {
         
            if(num == 0)
            {
                // Do Nothing
            } 
            else if (num == 1)
            {
                sb.Append(first);
            }
            else if (num == 2)
            {
                sb.Append(first).Append(first);
            }
            else if (num == 3)
            {
                sb.Append(first).Append(first).Append(first);
            }
            else if (num == 4)
            {
                sb.Append(first).Append(five);
            }
            else if (num == 5)
            {
                sb.Append(five);
            }
            else if (num == 6)
            {
                sb.Append(five).Append(first);
            }
            else if (num == 7)
            {
                sb.Append(five).Append(first).Append(first);
            }
            else if (num == 8)
            {
                sb.Append(five).Append(first).Append(first).Append(first);
            }
            else if (num == 9)
            {
                sb.Append(first).Append(ten);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 9.");
            }
        }
    }
}
