using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.TwoFurthestHousesWithDifferentColors
{
    public class Solution
    {
        public int MaxDistance(int[] colors)
        {
            int n = colors.Length;
            int maxDistance = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (colors[i] != colors[0])
                {
                    maxDistance = i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (colors[i] != colors[n - 1])
                {
                    maxDistance = Math.Max(maxDistance, n - 1 - i);
                    break;
                }
            }

            return maxDistance;
        }
    }
}
