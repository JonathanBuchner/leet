using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.Deleting.RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var ind = 0;
            var pos = 1;

            while(pos < nums.Length)
            {
                if(nums[ind] == nums[pos])
                {
                    pos++;
                }
                else 
                {
                    ind++;
                    nums[ind] = nums[pos];
                    pos++;
                }
            }

            return ind + 1;
        }
    }
}
