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
        private StringBuilder sb = new StringBuilder();

        public string IntToRoman(int num)
        {
            /*   
               I             1
               V             5
               X             10
               L             50
               C             100
               D             500
               M             1000
            */

            while (num >= 1000)
            {
                sb.Append("M");
                num -= 1000;
            }

            var hundreds = num / 100 % 10;
            var tens = num / 10 % 10;
            var ones = num % 10;

            sb.Append(Converter(hundreds, 'C', 'D', 'M'));
            sb.Append(Converter(tens, 'X', 'L', 'C'));
            sb.Append(Converter(ones, 'I', 'V', 'X'));

            return sb.ToString();
        }

        private string Converter(int num, char first, char five, char ten)
        {
            switch(num)
            {
                case 0:
                    return "";
                
                case 1:
                    return first.ToString();

                case 2:
                    return String.Concat(first, first);


                case 3:
                    return String.Concat(first, first, first); ;

                case 4:
                    return String.Concat(first, five);

                case 5:
                    return five.ToString();

                case 6:
                    return string.Concat(five, first);

                case 7:
                    return string.Concat(five, first, first);

                case 8:
                    return string.Concat(five, first, first, first);

                case 9:
                    return string.Concat(first, ten);

                default:
                    throw new ArgumentOutOfRangeException("Number must be between 0 and 9.");
            }
        }
    }
}
