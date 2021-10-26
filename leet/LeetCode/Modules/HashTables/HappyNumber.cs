﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.HappyNumber
{
    /*
     * Happy Number
     * Write an algorithm to determine if a number n is happy. A happy number is a number defined by the following process:
     
     * - Starting with any positive integer, replace the number by the sum of the squares of its digits.
     
     * - Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
     
     * - Those numbers for which this process ends in 1 are happy.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1131/
     */
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            return ReplaceWithSumOfSquare(n, set);
        }

        private bool ReplaceWithSumOfSquare(int n, HashSet<int> set)
        {
            var total = 0;
            var nums = n.ToString().ToCharArray();

            foreach (var num in nums)
            {
                var number = Int32.Parse(num.ToString());
                total = number * number + total;
            }

            if (total == 1)
            {
                return true;
            }
            else if (set.Contains(total))
            {
                return false;
            }
            else
            {
                set.Add(total);
                return ReplaceWithSumOfSquare(total, set);
            }
        }
    }
}
