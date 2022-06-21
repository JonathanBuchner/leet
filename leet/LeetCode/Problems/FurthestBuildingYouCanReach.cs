using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet.LeetCode.Problems.FurthestBuildingYouCanReach
{
    public class Solution
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var highests = new List<int>();
            var furthest = 0;
            var usedBricks = 0;

            for (var i = 1; i < heights.Length; i++)
            {
                var diff = heights[i] - heights[i - 1];
                
                if (diff > 0)
                {
                    highests.Add(diff);

                    if(highests.Count > ladders)
                    {
                        var lowest = highests[0];
                        for (var k = 1; k < highests.Count; k++)
                        {
                            lowest = Math.Min(lowest, highests[k]);
                        }
                        highests.Remove(lowest);

                        usedBricks += lowest;

                        if (usedBricks > bricks)
                        {
                            break;
                        }
                    }
                }

                furthest = i;
            }

            return furthest;
        }
    }
}
