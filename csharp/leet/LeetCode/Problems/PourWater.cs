using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PourWater
{
    public class Solution
    {
        public int[] PourWater(int[] heights, int volume, int k)
        {
            while(volume > 0)
            {
                var left_i = FallLeft(k, heights);
                var right_i = FallRight(k, heights);

                if (heights[left_i] >= heights[k] && heights[right_i] >= heights[k])
                {
                    heights[k]++;
                }
                else if (heights[left_i] < heights[k])
                {
                    heights[left_i]++;
                } else 
                {
                    heights[right_i]++;
                }
                volume--;
            }

            return heights;
        }

        private int FallLeft(int i, int[] heights)
        {
            if (i == 0)
                return i;

            if (heights[i] >= heights[i - 1])
            {
                var left_i = FallLeft(i - 1, heights);
                return heights[i] <= heights[left_i] ? i : left_i;
            }

            return i;
        }
        private int FallRight(int i, int[] heights)
        {
            if (i == heights.Length - 1)
                return i;

            if (heights[i] >= heights[i + 1])
            {
                var right_i = FallRight(i + 1, heights);
                return heights[i] <= heights[right_i] ? i : right_i;
            }

            return i;
        }
    }
}
