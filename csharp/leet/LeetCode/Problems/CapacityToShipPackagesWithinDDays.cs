using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.CapacityToShipPackagesWithinDDays
{
    /*
     * Capacity To Ship Packages Within D Days
     * 
     * Conveyor belt has packages that must be shipped from one port to another within days days.
     * 
     * The ith package on the conveyor belt has a weight of weights[i]. Each day, we load the ship with packages on the conveyor belt (in the order given by weights). We may not load more weight than the maximum weight capacity of the ship.
     * 
     * Return the least weight capacity of the ship that will result in all the packages on the conveyor belt being shipped within days days.
     * 
     * https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/description/
     */
    public class Solution
    {
        private int[] weights;
        private int days;

        public bool Feasability(int capacity)
        {
            var neededDays = 1;
            var current = 0;

            for (var i = 0; i < weights.Length; i++)
            {
                current += weights[i];

                if (current > capacity)
                {
                    neededDays++;
                    current = weights[i];
                }
            }

            return neededDays <= days;
        }

        public int ShipWithinDays(int[] weights, int days)
        {
            this.days = days;
            this.weights = weights;
            var total = 0;
            var max = 0;

            for (var i = 0; i < weights.Length; i++)
            {
                total += weights[i];
                max = Math.Max(max, weights[i]);
            }

            while (max < total)
            {
                var weight = (max + total) / 2;

                if (Feasability(weight))
                {
                    total = weight;
                }
                else
                {
                    max = weight + 1;
                }
            }

            return max;

        }
    }
}
