﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumMovestoEqualArrayElementsII
{
    /*
     * Minimum Moves to Equal Array Elements II
     * 
     * Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.  In one move, you can increment or decrement an element of the array by 1.
     * 
     * https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
     */
    public class Solution
    {
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            var moves = 0;
            var middle = nums.Length / 2;

            for (var i = 0; i < nums.Length; i++)
            {
                moves += Math.Abs(nums[middle] - nums[i]);
            }

            return moves;
        }
    }
}
