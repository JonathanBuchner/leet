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
            var result= new List<IList<int>>();
            var list = new List<int>();
            
            foreach(var num in nums)
            {
                list.Add(num);
            }    
            
            list.Sort();

            for(var left = 0; left < list.Count - 2 && list[left] <= 0; left++)
            {
                var l = left + 1;
                var r = list.Count - 1;

                while( l < r)
                {
                    var total = list[left] + list[l] + list[r];

                    if(total == 0)
                    {
                        var isAdd = true;
                        
                        foreach(var item in result)
                        {
                            if(
                                item[0] == list[left] &&
                                item[1] == list[l] &&
                                item[2] == list[r]
                                )
                            {
                                isAdd = false;
                            }
                        }
                        if(isAdd)
                        {
                            result.Add(new List<int>() { list[left], list[l], list[r] });
                        }

                        r--;
                    }
                    else if (total > 0)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }

            return result;
        }
    }
}
