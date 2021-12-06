using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int area = 0, left = 0, right = height.Length - 1;

            while (right > left)
            {
                area = Math.Max(Math.Min(height[left], height[right]) * (right - left), area);

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }


            return area;
        }

        public int GetArea(int[] height)
        {
            var area = 0;

            if (height.Length <= 2)
            {
                return area;
            }

            var curr = 0;
            var highestIndex = height[0];
            for (var i = 1; i < height.Length; i++)
            {
                if (height[i] > curr)
                {
                    curr = i;
                    highestIndex = height[i];
                }
            }

            var left = 1;
            var leftHighest = height[0];
            while (left < highestIndex)
            {
                if (leftHighest > height[left])
                {
                    area += leftHighest - height[left];
                }
                else
                {
                    leftHighest = height[left];
                }

                left++;
            }

            var right = height.Length - 2;
            var rightHighest = height[height.Length - 1];
            while (right > highestIndex)
            {
                if (rightHighest > height[right])
                {
                    area += rightHighest - height[right];
                }
                else
                {
                    rightHighest = height[right];
                }

                right--;
            }

            return area;
        }
    }
}
