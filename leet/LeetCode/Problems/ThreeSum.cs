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

            var doubles = new Dictionary<int, List<int>>();
            var i = 0;
            
            while(i < nums.Length - 2)
            {
                var k = i + 1;
                while ( k < nums.Length - 1)
                {
                    doubles.TryAdd(-1 * (nums[i] + nums[k]), new List<int>() { nums[i], nums[k] });
                    k++;
                }
                i++;
            }

            var m = 2;
            var set = new HashSet<List<int>>();
            
            while(m < nums.Length)
            {
                var j Math
                if (doubles.ContainsKey(nums[j]))
                {
                    var answer = new List<int>() {doubles[nums[j]][0], doubles[nums[j]][1], nums[j] };
                    answer.Sort();

                    var same = false;
                    foreach (var curr in answers)
                    {
                        same = true;
                        for (var l = 0; l < 3; l++)
                        {
                            if(curr[l] != answer[l])
                            {
                                same = false;
                                break;
                            }
                        }
                        if (same) { break; }
                    }

                    if (!same)
                    {
                        answers.Add(answer);
                    }
                }
                j++;
            }

            return answers;
        }
    }
}
