using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.ContainsDuplicateII
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>(); // Key is number, Value is indice.

            for (var i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {

                    if(i - dict[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}
