using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FourSum
{
    /*
     * SOLUTION NOT OPTIMIZED.
     * 
     *  4Sum
     * 
     * Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
     * 
     *  0 <= a, b, c, d < n
     *  a, b, c, and d are distinct.
     *  nums[a] + nums[b] + nums[c] + nums[d] == target
     *  
     *  You may return the answer in any order.
     * 
     * https://leetcode.com/problems/4sum/
     */
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {

            var dict = new Dictionary
            var solutions = new HashSet<string>();
            var answers = new List<IList<int>>();

            Array.Sort(nums);

            var p1 = 0;
            var p2 = 1;
            var p3 = 2;
            var p4 = 3;

            while (p1 < nums.Length - 3)
            {
                //Console.WriteLine($"p1: {p1}");
                p2 = p1 + 1;
                while (p2 < nums.Length - 2)
                {
                    p3 = p2 + 1;
                    //Console.WriteLine($"p2: {p2}");
                    while (p3 < nums.Length - 1)
                    {
                        p4 = p3 + 1;
                        //Console.WriteLine($"p3: {p3}");
                        while (p4 < nums.Length)
                        {
                            //Console.WriteLine($"p4: {p4}");
                            var total = nums[p1] + nums[p2] + nums[p3] + nums[p4];

                            // Console.WriteLine($"Total: { total }; p1: {nums[p1]}; p2: {nums[p2]}; p3: {nums[p3]}; p4: {nums[p4]}.");

                            if (total == target)
                            {
                                var set = String.Concat(
                                    nums[p1],
                                    nums[p2],
                                    nums[p3],
                                    nums[p4]
                                );

                                if (!solutions.Contains(set))
                                {
                                    answers.Add(new List<int>() { nums[p1], nums[p2], nums[p3], nums[p4] });
                                    solutions.Add(set);
                                }
                            }

                            // if(total > target)
                            // {
                            //     break;
                            // }

                            p4++;
                        }

                        // if(target < nums[p1] + nums[p2] + nums[p3])
                        // {
                        //     break;
                        // }

                        p3++;
                    }

                    // if(target < nums[p1] + nums[p2])
                    // {
                    //     break;
                    // }

                    p2++;
                }

                p1++;
            }

            return answers;
        }
    }
}
