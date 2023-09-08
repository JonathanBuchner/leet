using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace leet.LeetCode.Problems.Minimum_falling_path_sum
{
    public class Solution
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            for(var i = 1; i < matrix.Length; i++)
            {
                for(var k = 0; k < matrix[i].Length; k++)
                {
                    if(k == 0)
                    {
                       matrix[i][k] = matrix[i][k] + Math.Min(matrix[i - 1][k], matrix[i - 1][k+1]);
                    }
                    else if (k == matrix[i].Length - 1)
                    {
                        matrix[i][k] = matrix[i][k] + Math.Min(matrix[i - 1][k-1], matrix[i - 1][k]);
                    }
                    else
                    {
                        matrix[i][k] = 
                            matrix[i][k] + 
                            Math.Min(matrix[i - 1][k - 1], 
                                Math.Min(matrix[i - 1][k], matrix[i - 1][k+1]));
                    }
                }
            }

            return matrix[matrix.Length - 1].Min();
        }
    }
}
