using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.AddStrings
{
    /*
     * Add strings
     * 
     * Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
     * 
     * https://leetcode.com/problems/add-strings/
     */
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            var sb = new StringBuilder();
            var n1 = num1.Length - 1;
            var n2 = num2.Length - 1;
            var carry = 0;

            try
            {
                while (n1 >= 0 && n2 >= 0)
                {
                    var c1 = Char.GetNumericValue(num1[n1]);
                    var c2 = Char.GetNumericValue(num2[n2]);

                    var total = c1 + c2 + carry;
                    sb.Append(total % 10);

                    carry = total > 9 ? 1 : 0;

                    n1--;
                    n2--;
                }

                while (n1 >= 0)
                {
                    var c1 = Char.GetNumericValue(num1[n1]);
                    var total = c1 + carry;

                    sb.Append(total % 10);
                    carry = total > 9 ? 1 : 0;

                    n1--;
                }

                while (n2 >= 0)
                {
                    var c2 = Char.GetNumericValue(num2[n2]);
                    var total = c2 + carry;

                    sb.Append(total % 10);
                    carry = total > 9 ? 1 : 0;

                    n2--;
                }

                if (carry == 1)
                {
                    sb.Append('1');
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new String(sb.ToString().Reverse().ToArray());
        }
    }
}
