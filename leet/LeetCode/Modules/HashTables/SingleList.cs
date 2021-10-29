using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.SingleList
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var number = nums[i];
                result = result ^ number;
            }

            return result;
        }
    }
}
