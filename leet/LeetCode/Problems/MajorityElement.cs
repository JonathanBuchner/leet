using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var count = 0;
            var highNum = 0;

            if (nums.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    ++dict[num];
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            foreach (var entry in dict)
            {
                if (entry.Value > count)
                {
                    count = entry.Value;
                    highNum = entry.Key;
                }
            }

            return highNum;
        }
    }
}
