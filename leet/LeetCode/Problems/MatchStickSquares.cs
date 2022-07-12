using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MatchstickToSquares
{
    /*
     * Matchsticks to Square
     * 
     * You are given an integer array matchsticks where matchsticks[i] is the length of the ith matchstick. You want to use all the matchsticks to make one square. You should not break any stick, but you can link them up, and each matchstick must be used exactly one time.  Return true if you can make this square and false otherwise.
     * 
     * https://leetcode.com/problems/matchsticks-to-square/
     * 
     * https://en.wikipedia.org/wiki/Bin_packing_problem
     */
    public class Solution
    {
        public List<int> nums;
        public int[] sums;
        public int possibleSquareSide;

        public Solution()
        {
            this.sums = new int[4];
        }

        // Depth First Search function.
        public bool dfs(int index)
        {

            // If we have exhausted all our matchsticks, check if all sides of the square are of equal length
            if (index == this.nums.Count)
            {
                return sums[0] == sums[1] && sums[1] == sums[2] && sums[2] == sums[3];
            }

            // Get current matchstick.
            int element = this.nums[index];

            // Try adding it to each of the 4 sides (if possible)
            for (int i = 0; i < 4; i++)
            {
                if (this.sums[i] + element <= this.possibleSquareSide)
                {
                    this.sums[i] += element;
                    if (this.dfs(index + 1))
                    {
                        return true;
                    }
                    this.sums[i] -= element;
                }
            }

            return false;
        }

        public bool Makesquare(int[] nums)
        {
            // Empty matchsticks.
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            // Find the perimeter of the square (if at all possible)
            int L = nums.Length;
            int perimeter = 0;
            for (int i = 0; i < L; i++)
            {
                perimeter += nums[i];
            }

            this.possibleSquareSide = perimeter / 4;
            if (this.possibleSquareSide * 4 != perimeter)
            {
                return false;
            }

            // Convert the array of primitive int to ArrayList (for sorting).
            this.nums = nums.ToList();
            this.nums.Sort((a, b) => b.CompareTo(a));

            return this.dfs(0);
        }
    }
}
