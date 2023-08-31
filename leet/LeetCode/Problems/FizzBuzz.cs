using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FizzBuzz
{
    /*
     * Fizz Buzz
     * 
     * Given an integer n, return a string array answer (1-indexed) where:
     *   answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
     *   answer[i] == "Fizz" if i is divisible by 3.
     *   answer[i] == "Buzz" if i is divisible by 5.
     *   answer[i] == i (as a string) if none of the above conditions are true.
     * 
     * https://leetcode.com/problems/fizz-buzz/
     */
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else
                {
                    list.Add(Convert.ToString(i));
                }
            }

            return list;
        }
    }
}
