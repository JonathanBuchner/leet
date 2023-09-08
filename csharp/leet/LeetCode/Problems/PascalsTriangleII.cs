using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PascalsTriangleII
{
    /*
     * Pascal's Triangle II
     * 
     * Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
     * 
     * https://leetcode.com/problems/pascals-triangle-ii/
     */
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var row = 0;
            var prev = new List<int>()
        {
          1
        };

            while (row < rowIndex)
            {
                var curr = new List<int>();

                for (var i = 0; i < prev.Count; i++)
                {
                    if (i == 0)
                    {
                        curr.Add(prev[i]);
                    }
                    else
                    {
                        curr.Add(prev[i] + prev[i - 1]);
                    }

                    if (i == prev.Count - 1)
                    {
                        curr.Add(prev[prev.Count - 1]);
                    }
                }

                prev = curr;
                ++row;
            }

            return prev;
        }
    }
}
