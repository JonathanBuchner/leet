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
            var i = 0;
            var highestClimbs = new PriorityQueue<int, int>();
            var usedBricks = 0;

            while(i < heights.Length - 1)
            {
                var diff = heights[i + 1] - heights[i];

                if (diff > 0)
                {
                    if(highestClimbs.Count < ladders)
                    {
                        highestClimbs.Enqueue(diff, diff);
                        i++;
                        continue;
                    }

                    usedBricks += highestClimbs.EnqueueDequeue(diff, diff);

                    if (usedBricks > bricks)
                    {
                        break;
                    }
                }

                i++;
            }

            return i;
        }
    }
}
