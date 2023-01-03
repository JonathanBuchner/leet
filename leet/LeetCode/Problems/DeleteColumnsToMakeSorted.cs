using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DeleteColumnsToMakeSorted
{
    /*
     * You are given an array of n strings strs, all of the same length. The strings can be arranged such that there is one on each line, making a grid. For example, strs = ["abc", "bce", "cae"] can be arranged as:
        abc
        bce
        cae
     * You want to delete the columns that are not sorted lexicographically. In the above example (0-indexed), columns 0 ('a', 'b', 'c') and 2 ('c', 'e', 'e') are sorted while column 1 ('b', 'c', 'a') is not, so you would delete column 1.
     * 
     * Return the number of columns that you will delete.
     * 
     * https://leetcode.com/problems/delete-columns-to-make-sorted/
     */
    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            var colsDelete = 0;

            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var k = 1; k < strs.Length; k++)
                {
                    if (strs[k - 1][i] > strs[k][i])
                    {
                        colsDelete++;

                        break;
                    }
                }
            }

            return colsDelete;
        }
    }
}
