using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PaintHouse
{
    /*
     * Paint House  
     * 
     * There is a row of n houses, where each house can be painted one of three colors: red, blue, or green. The cost of painting each house with a certain color is different. You have to paint all the houses such that no two adjacent houses have the same color.
     * 
     * Return the minimum cost to paint all houses.
     * 
     * https://leetcode.com/problems/paint-house/
     */
    public class Solution
    {
        public int MinCost(int[][] costs)
        {
            if(costs.Length == 0)
            {
                throw new ArgumentException("There must be at least on house.");
            }

            for (var i = 1; i < costs.Length; ++i)
            {
                for(var k = 0; k < costs[i].Length; ++k)
                {
                    var previousLowest = Int32.MaxValue;

                    for(var j = 0; j < costs[i].Length; ++j)
                    {
                        if(j == k)
                        {
                            continue;
                        }
                        previousLowest = Math.Min(previousLowest, costs[i-1][j]);
                    }

                    costs[i][k] += previousLowest;
                }
            }

            return costs[costs.Length - 1].Min();
        }
    }
}
