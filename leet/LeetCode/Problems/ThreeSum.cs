using System;
using System.Collections.Generic;
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
            var answers = new List<IList<int>>();
            
            if (nums.Length < 3)
            {
                return answers;
            }

            var twosums = new List<int[]>();

            var i = 0;
            while(i < nums.Length - 2)
            {
                var j = i + 1;
                while (j < nums.Length - 1)
                {
                    var sum = nums[i] + nums[j];
                    twosums.Add( new int[3] { sum, i, j } );
                    j++;
                }

                i++;
            }

            foreach (var entry in twosums)
            {
                var k = entry[2]+ 1;
                
                while (k < nums.Length)
                {
                    if (entry[0] + nums[k] == 0)
                    {
                            var answer = new List<int>() { entry[1], entry[2], k };
                            answers.Add(answer);
                    }

                    k++;
                }
            }

            return answers;
        }
    }
}
