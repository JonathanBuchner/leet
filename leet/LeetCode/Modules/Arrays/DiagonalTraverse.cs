using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays
{
    /*
     * Diagonal Traverse
     * 
     * Given an m x n matrix mat, return an array of all the elements of the array in a diagonal order.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
     */
    public class Solution
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            throw new NotImplementedException();

            var arr = new int[mat.Length * mat[0].Length];
            var x = 0;
            var y = 0;
            var i = 0;
            var isUp = true;

            while (i < arr.Length)
            {
                arr[i] = mat[x][y];

                if (isUp)
                {
                    if (x == 0 || y == mat[0].Length)
                    {
                        isUp = false;

                        
                    }

                    --x;
                    ++y;


                }
                else
                {
                    if (y == 0)
                    {
                        isUp = false;
                    }
                    else
                    {
                        --y;
                    }

                    ++x;
                }

                ++i;
            }

            return arr;
        }
    }
}
