using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.RotateImage
{
    /*
     * Rotate Image
     * 
     * You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
     * 
     * You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/202/
     */
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            for(var h = 0; h < matrix.Length / 2; h++)
            {
                var s = matrix.Length - 1 - h;
                for (var i = 0; i + 2 * h < matrix.Length - 1; i++)
                {
                    var temp = matrix[s - i][h];
                    matrix[s - i][h] = matrix[s][s - i];
                    matrix[s][s - i] = matrix[h + i][s];
                    matrix[h + i][s] = matrix[h][h + i];
                    matrix[h][h + i] = temp;
                }
            }
        }
    }
    
}
