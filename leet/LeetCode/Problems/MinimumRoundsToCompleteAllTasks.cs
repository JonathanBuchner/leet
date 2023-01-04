using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumRoundsToCompleteAllTasks
{
    /*
     * Minimum Rounds to Complete All Tasks
     * 
     * You are given a 0-indexed integer array tasks, where tasks[i] represents the difficulty level of a task. In each round, you can complete either 2 or 3 tasks of the same difficulty level.
     * 
     * Return the minimum rounds required to complete all the tasks, or -1 if it is not possible to complete all the tasks.
     * 
     * https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/
     */
    public class Solution
    {
        public int MinimumRounds(int[] tasks)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < tasks.Length; i++)
            {
                if (dict.ContainsKey(tasks[i]))
                {
                    dict[tasks[i]]++;
                }
                else
                {
                    dict.Add(tasks[i], 1);
                }
            }

            var result = 0;
            foreach (var entry in dict)
            {
                if (entry.Value == 1)
                {
                    return -1;
                }
                else
                {
                    result += entry.Value / 3;

                    if (entry.Value % 3 != 0)
                    {
                        result += 1;
                    }
                }
            }

            return result;
        }
    }
}
