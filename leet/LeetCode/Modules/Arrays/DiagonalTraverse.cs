using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.DiagonalTraverse
{
    /*
     * Diagonal Traverse
     * 
     * Given an m x n matrix mat, return an array of all the elements of the array in a diagonal order.
     * 
     * https://leetcode.com/problems/diagonal-traverse/
     */
    public class Solution
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            var arr = new int[mat.Length * mat[0].Length];
            var x = 0;
            var xmax = mat.Length - 1;
            var y = 0;
            var ymax = mat[0].Length - 1;
            var i = 0;
            var isUp = true;

            while (i < arr.Length)
            {
                arr[i] = mat[x][y];

                if (isUp)
                {
                    if (y == ymax)
                    {
                        x++;
                        isUp = !isUp;
                    }
                    else if (x == 0)
                    {
                        y++;
                        isUp = !isUp;

                    }
                    else
                    {
                        x--;
                        y++;
                    }
                }
                else
                {
                    if (x == xmax)
                    {
                        y++;
                        isUp = !isUp;
                    }
                    else if (y == 0)
                    {
                        x++;
                        isUp = !isUp;
                    }
                    else
                    {
                        x++;
                        y--;
                    }
                }
                ++i;
            }

            return arr;
        }
    }
}
