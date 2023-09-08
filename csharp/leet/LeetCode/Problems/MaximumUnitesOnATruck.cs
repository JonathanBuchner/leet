using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaximumUnitesOnATruck
{
    /*
     * Maximum units on a truck
     * 
     * Return the maximum total number of units that can be put on the truck.
     * 
     * https://leetcode.com/problems/maximum-units-on-a-truck/
     */
    public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (a,b) => b[1].CompareTo(a[1]));
            var boxes = 0;
            var units = 0;

            for(var i = 0; i < boxTypes.Length; i++)
            {
                var additionalBoxes = Math.Min(boxTypes[i][0], truckSize - boxes);
                units += additionalBoxes * boxTypes[i][1];
                boxes += additionalBoxes;

                if(boxes >= truckSize)
                {
                    break;
                }
            }

            return units;
        }
    }
}
