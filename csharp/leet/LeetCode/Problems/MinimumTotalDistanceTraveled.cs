using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumTotalDistanceTraveled
{
    /**
     * 2463. Minimum Total Distance Traveled
     * 
     * https://leetcode.com/problems/minimum-total-distance-traveled
     */

    public class Solution
    {
        private SortedDictionary<int, int> dict;
        public long MinimumTotalDistance(IList<int> robot, int[][] factory)
        {
            dict = GetSortedFactorySet(factory);
            var robot_sorted = robot.ToList();
            robot_sorted.Sort();

            return MoveNextRobot(0, robot_sorted);
        }

        private long MoveNextRobot(int index, IList<int> robot)
        {
            // If no more items on list.
            if (index >= robot.Count)
                return 0;

            // If start on factory
            if (dict.ContainsKey(robot[index]))
            {
                DecrementOrRemoveEntry(robot[index]);
                return MoveNextRobot(++index, robot);
            }

            var ps = GetPredSuccFromDict(robot[index]);

            long left_total = Int64.MaxValue;
            long right_total = Int64.MaxValue;
            long left_dist = ps[0] != null ? robot[index] - (long) ps[0] : Int64.MaxValue;
            long right_dist = ps[1] != null ? (long) ps[1] - robot[index] : Int64.MaxValue;

            if (left_dist <= right_dist || ps[1] == null)
            {
                DecrementOrRemoveEntry((int)ps[0]);
                var total = MoveNextRobot(index + 1, robot) + left_dist;
                IncrementOrAddEntry((int)ps[0]);
                return total;
            }

            DecrementOrRemoveEntry((int)ps[1]);
            right_total = MoveNextRobot(index + 1, robot) + right_dist;
            IncrementOrAddEntry((int)ps[1]);

            if (ps[0] != null)
            {
                DecrementOrRemoveEntry((int) ps[0]);
                left_total = MoveNextRobot(index + 1, robot) + left_dist;
                IncrementOrAddEntry((int) ps[0]);
            }

            return left_total < right_total ? left_total : right_total;
        }

        private void DecrementOrRemoveEntry(int index)
        {
            if (--dict[index] < 1)
                dict.Remove(index);
        }

        private void IncrementOrAddEntry(int index)
        {
            if (!dict.ContainsKey(index))
                dict.Add(index, 0);

            ++dict[index];
        }

        private int?[] GetPredSuccFromDict(int index)
        {
            var ps = new int?[2];
            var prev = new KeyValuePair<int, int>();

            foreach (var pair in dict)
            {
                if (pair.Key > index)
                {
                    ps[0] = prev.Key == Int32.MinValue ? null : prev.Key;
                    ps[1] = pair.Key == Int32.MaxValue ? null : pair.Key;
                    break;
                }

                prev = pair;
            }

            return ps;
        }

        private SortedDictionary<int, int> GetSortedFactorySet(int[][] factory)
        {
            var new_dict = new SortedDictionary<int, int>();

            new_dict.Add(Int32.MaxValue, Int32.MaxValue);
            new_dict.Add(Int32.MinValue, Int32.MinValue);

            for (var i = 0; i < factory.Length; i++)
            {
                if (factory[i][1] > 0)
                    new_dict.Add(factory[i][0], factory[i][1]);
            }

            return new_dict;
        }
    }
}
