using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace leet.LeetCode.Problems.ThreeSum
{

    public class Solution
    {
        /*
         * 3Sum
         * 
         * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.  Notice that the solution set must not contain duplicate triplets.
         * 
         * https://leetcode.com/problems/3sum/
         */

        public IList<IList<int>> ThreeSum(int[] nums)
        {

            throw new NotImplementedException();

            var answers = new List<IList<int>>();
            var list = new List<int>();

            if (nums.Length < 3)
            {
                return answers;
            }

            for (var x = 0; x < nums.Length; x++)
            {
                list.Add(nums[x]);
            }
            list.Sort();

            var i = 0;
            var j = list.Count - 1;

            while (i < j - 1)
            {

                var k = i + 1;
                while( k < j)
                {

                    k++;
                }
            }

            return answers;
        }
    }
}
