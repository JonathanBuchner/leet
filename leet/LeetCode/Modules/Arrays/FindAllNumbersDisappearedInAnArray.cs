using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.FindAllNumbersDisappearedInAnArray
{
    /*
     * Find All Numbers Disappeared in an Array
     * 
     * Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums
     * 
     * https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3270/
     */
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var test = new bool[nums.Length + 1];
            var list = new List<int>();

            for(var i = 0; i < nums.Length; i++)
            {
                test[nums[i]] = true;
            }

            for (var i = 1; i < test.Length; i++)
            {
                if (test[i] == false)
                {
                    list.Add(i);
                }
            }

            return list;

        }
    }
}
