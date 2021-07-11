using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Linq;

namespace leet.LeetCode.Modules.Arrays.HeightChecker
{
    /*
     * Height Checker
     * 
     * A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.
     * 
     * You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).
     * 
     * Return the number of indices where heights[i] != expected[i].
     * 
     * https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
     */
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            var matches = 0;

            var ordered = new int[heights.Length];

            Array.Copy(heights, ordered, heights.Length);
            Array.Sort(ordered);

            for (var i = 0; i < heights.Length; i++)
            {
                if (heights[i] != ordered[i]) matches++;
            }

            return matches;
        }
    }
}
