using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts
{
    /*
     * Maximum Area of a Piece of Cake After Horizontal and Vertical Cuts
     * 
     * Return the maximum area of a piece of cake after you cut at each horizontal and vertical position provided in the arrays horizontalCuts and verticalCuts
     * 
     * https://leetcode.com/problems/maximum-area-of-a-piece-of-cake-after-horizontal-and-vertical-cuts/
     */
    public class Solution
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            long greatestHeight = 0;
            long greatestWidth = 0;
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);

            //Calculate larget height
            if(horizontalCuts.Length > 0)
            {
                greatestHeight = Math.Max(horizontalCuts[0], h - horizontalCuts[horizontalCuts.Length - 1]);
            }
            else
            {
                greatestHeight = h;
            }

            for(var i = 0; i < horizontalCuts.Length - 1; i++)
            {
                greatestHeight = Math.Max(greatestHeight, horizontalCuts[i + 1] - horizontalCuts[i]);
            }

            // Calculate larged width
            if (verticalCuts.Length > 0)
            {
                greatestWidth = Math.Max(verticalCuts[0], w - verticalCuts[verticalCuts.Length - 1]);
            }
            else
            {
                greatestWidth = w;
            }

            for (var i = 0; i < verticalCuts.Length - 1; i++)
            {
                greatestWidth = Math.Max(greatestWidth, verticalCuts[i + 1] - verticalCuts[i]);
            }

            var result = (int)((greatestHeight * greatestWidth) % (1000000007));

            return result;
        }
    }
}
