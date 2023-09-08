using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace leet.LeetCode.Problems.AddBinary
{
    /*
     * Add Binary
     * 
     * Given two binary strings a and b, return their sum as a binary string.
     * 
     * https://leetcode.com/problems/add-binary/
     */
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var sb = new StringBuilder();

            string longer = a.Length > b.Length ? a : b;
            string shorter = a.Length <= b.Length ? a : b;
            longer = new string(longer.ToCharArray().Reverse().ToArray());
            shorter= new string(shorter.ToCharArray().Reverse().ToArray());
            var carry = 0;
            var i = 0;


           while(i < shorter.Length)
            {
                if (shorter[i] == '1' && longer[i] == '1' && carry == 1)
                {
                    //carry is already 1
                    sb.Append("1");
                }
                else if (
                    shorter[i] == '1' && longer[i] == '1' && carry == 0 || 
                    shorter[i] == '1' && longer[i] == '0' && carry == 1 || 
                    shorter[i] == '0' && longer[i] == '1' && carry == 1)
                {
                    carry = 1;
                    sb.Append("0");
                }
                else if (shorter[i] == '0' && longer[i] == '0' && carry == 0)
                {
                    //Carry already is 0
                    sb.Append(0);
                }
                else
                {
                    carry = 0;
                    sb.Append("1");
                }
                i++;
            }

            while(i < longer.Length)
            {
                if (carry == 1 && longer[i] == '1')
                {
                    carry = 1;
                    sb.Append("0");
                } 
                else if(carry == 0 && longer[i] == '0')
                {
                    sb.Append("0");
                }
                else
                {
                    carry = 0;
                    sb.Append("1");
                }
                i++;
            }

            if (carry == 1)
            {
                sb.Append("1");
            }

            return new String(sb.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
