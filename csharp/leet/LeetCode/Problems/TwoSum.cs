using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            
            for(var i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    return new int[] { dict[nums[i]], i };
                }
                else
                {
                    dict.TryAdd(target - nums[i], i);
                }
            }

            return new int[] { -1, -1};
        }
    }
}
