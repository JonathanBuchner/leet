using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.AddToArrayFormOfInteger
{
    /*
     * Array-Form of Integer
     * 
     * The array-form of an integer num is an array representing its digits in left to right order.
     * 
     * https://leetcode.com/problems/add-to-array-form-of-integer/description/
     */
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            var list = new List<int>();
            var pn = num.Length - 1;
            var carry = 0;

            while (pn >= 0 && k != 0)
            {
                var t2 = k % 10;
                var total = num[pn] + t2 + carry;

                if (total >= 10)
                {
                    carry = 1;
                    total -= 10;
                }
                else
                {
                    carry = 0;
                }

                list.Add(total);
                k = k / 10;
                pn--;
            }

            while (pn >= 0)
            {
                var total = num[pn] + carry;

                if (total >= 10)
                {
                    carry = 1;
                    total -= 10;
                }
                else
                {
                    carry = 0;
                }

                list.Add(total);

                pn--;
            }

            while (k != 0)
            {
                var t2 = k % 10;
                var total = t2 + carry;

                if (total >= 10)
                {
                    carry = 1;
                    total -= 10;
                }
                else
                {
                    carry = 0;
                }

                list.Add(total);
                k = k / 10;
            }

            if (carry == 1)
            {
                list.Add(carry);
            }

            list.Reverse();

            return list;
        }
    }
}
