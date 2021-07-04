using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.SetMatrixZeroes
{
    /*
     * Set Matrix Zeroes
     * 
     * Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's, and return the matrix.
     * 
     * You must do it in place.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/203/
     */
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            var x = 0;
            var y = 0;
            var firstRow = false;
            var firstColumn = false;

            // Mark rows and colums 
            while( y < matrix.Length)
            {
                while (x < matrix[0].Length)
                {
                    if (matrix[y][x] == 0)
                    {
                        if(y == 0)
                        {
                            firstRow = true;
                        }
                        else 
                        {
                            // Marking first column to represent rows
                            matrix[0][x] = 0;
                        }
                        if(x == 0)
                        {
                            firstColumn = true;
                        }
                        else
                        {
                            //Marking first row to represent columns
                            matrix[y][0] = 0;
                        }
                    }
                    x++;
                }
                x = 0;
                y++;
            }

            //Fill in rows
            for (var i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    for(var j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            //Fill in columns
            for (var i = 1; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    for (var j = 0; j < matrix.Length; j++)
                    {
                        matrix[j][i] = 0;
                    }   
                }
            }

            // Fill in first row
            if(firstRow)
            {
                for(var i = 0; i <matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }
            // Fill in first column 
            if (firstColumn)
            {
                for (var i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

        }
    }
}
