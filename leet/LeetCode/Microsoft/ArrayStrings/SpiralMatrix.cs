using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.SpiralMatrix
{
    /*
     * SpiralMatrix
     * 
     * Given an m x n matrix, return all elements of the matrix in spiral order.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/178/
     */
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var list = new List<int>();
            var o = 0;
            var row = matrix[0].Length - 1;
            var col = matrix.Length - 1;

            while (list.Count < matrix.Length * matrix[0].Length)
            {
                for (var r = o; r < matrix[o].Length - o; r++)
                {
                    list.Add(matrix[o][r]);
                }

                for (var c = 1 + o; c < matrix.Length - o; c++)
                {
                    list.Add(matrix[c][row - o]);
                }

                if (2 * o  + 1 < matrix.Length)
                {
                    for (var r = row - 1 - o; r >= o; r--)
                    {
                        list.Add(matrix[col - o][r]);
                    }

                    if (2 * o + 1 < matrix[0].Length)
                    {
                        for (var c = col - 1 - o; c > o; c--)
                        {
                            list.Add(matrix[c][o]);
                        }
                    }
                }

                o++;
            }

            return list;
        }
    }
}
