namespace leet.LeetCode.Microsoft.ArrayStrings.TrappingRainWater
{
    /*
     * Trapping Rain Water
     * Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
     * 
     * Constraints:
     *  - n == height.length
     *  - 0 <= n <= 3 * 104
     *  - 0 <= height[i] <= 105
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/211/
     */

    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length < 3) return 0;

            var higheshRightestIndex = 0;
            
            for (var i = 0; i < height.Length; i++)
            {
                if(height[i] >= height[higheshRightestIndex]) higheshRightestIndex = i;
            }
  
            // Calculating from left to highest right index
            var total = 0;
            var left = 0;
            var right = 1;
            
            while(right < higheshRightestIndex)
            {
                var curr = height[left];
                var next = height[right];

                if (curr <= next)
                {
                    left = right;
                    right++;
                }
                else    
                {
                    total += curr - next;
                    right++;
                }
            }

            // Calculating for right to highest right index;
            right = height.Length - 1;
            left = height.Length - 2;
            while (left > higheshRightestIndex)
            {
                var curr = height[right];
                var next = height[left];

                if (curr < next)
                {
                    right = left;
                    left--;
                }
                else
                {
                    total += curr - next;
                    left--;
                }
            }

            return total;
        }
    }
}