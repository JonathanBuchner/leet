using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet.LeetCode.Problems.FurthestBuildingYouCanReach
{
    public class Solution
    {
        private int[] heights;
        private int bricks;
        private int ladders;
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            this.heights = heights;
            this.bricks = bricks;
            this.ladders = ladders;

            var buldingsTraverse = 0;

            var index = heights.Length / 2;

            return buildingTraverse;
        }

        private bool Furthest(int index, out int lastIndex)
        {
            if(index)

            var climbs = GetClimbList(0, index);

            return CanTraverse(climbs);
        }

        private List<int> GetClimbList(int indexLeft, int indexRight)
        {
            var list = new List<int>();

            for (int i = indexLeft; i < heights.Length - 1 && i <= indexRight; i++)
            {
                var diff = heights[i + 1] - heights[i];
                if(diff > 0)
                {
                    list.Add(diff);
                }
            }

            list.Sort( (a,b) => b.CompareTo(a));

            return list;
        }

        private bool CanTraverse(List<int> climbs)
        {
            if(climbs.Count <= ladders)
            {
                return true;
            }
            climbs.RemoveRange(0, ladders);
            var bricksNeeded = climbs.Sum( c => c);

            return bricks >= bricksNeeded;
        }
    }
}
