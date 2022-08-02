using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.SpiralMatrix
{
    /*
     * Spiral Matrix
     * 
     * iven an m x n matrix, return all elements of the matrix in spiral order.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1168/
     */
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();
            var offset = 0;
            var counter = 0;
            var direction = "right";
            var x = 0;
            var y = 0;

            while (counter < matrix[0].Length * matrix.Length)
            {
                result.Add(matrix[x][y]);
                counter++;

                switch (direction)
                {
                    case "right":
                        if (y >= matrix[0].Length - offset - 1)
                        {
                            direction = "down";
                            ++x;
                        }
                        else
                        {
                            ++y;
                        }
                        break;

                    case "down":
                        if (x >= matrix.Length - offset - 1)
                        {
                            direction = "left";
                            --y;
                        }
                        else
                        {
                            ++x;
                        }
                        break;

                    case "left":
                        if (y <= 0 + offset)
                        {
                            direction = "up";
                            ++offset;
                            --x;

                        }
                        else
                        {
                            --y;
                        }
                        break;

                    case "up":
                        if (x <= 0 + offset)
                        {
                            direction = "right";
                            ++y;

                        }
                        else
                        {
                            --x;
                        }
                        break;

                    default:
                        throw new ArgumentException($"Cannot support this type of matrix. x is {x}.  y is {y}.");
                }
            }

            return result;
        }
    }
}
