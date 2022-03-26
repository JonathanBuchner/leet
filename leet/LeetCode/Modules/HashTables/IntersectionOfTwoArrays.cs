using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.IntersectionOfTwoArrays
{
    /*
     *  Intersection of Two Arrays
     * 
     * Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/
     */
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var result = new List<int>() { };

            foreach(var num in set2)
            {
                if (set1.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
