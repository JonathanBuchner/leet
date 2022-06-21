using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ClimbingStairs
{
    public class Solution
    {
        private int[] steps;

        public int ClimbStairs(int n)
        {
            steps = new int[n + 1];

            return Step(0);
        }

        private int Step(int i)
        {
            if (i > steps.Length - 1)
            {
                return 0;
            }
            else if (i == steps.Length - 1)
            {
                return 1;
            }
            else if (steps[i] > 0)
            {
                return steps[i];
            }
            else
            {
                return steps[i] = Step(i + 1) + Step(i + 2);
            }

        }
    }
}
