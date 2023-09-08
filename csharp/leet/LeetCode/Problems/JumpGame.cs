using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.JumpGame
{
    /*
     * Jump Game VI
     * 
     * Return the maximum score you can get.
     * 
     * https://leetcode.com/problems/jump-game-vi/
     */
    public class Solution
    {
        public int MaxResult(int[] nums, int k)
        {
            int score = nums[0];
            var squares = new LinkedList<int[]>();
            squares.AddFirst(new int[] { 0, score });
            var jumps = k;
            
            for (int i = 1; i < nums.Length; i++)
            {
                while (squares.Count > 0 && squares.First.Value[0] < i - jumps)
                {
                    squares.RemoveFirst();
                }
                score = squares.First.Value[1]  + nums[i];
                // pop the smaller value
                
                while (squares.Count > 0 && score >= squares.Last.Value[1])
                {
                    squares.RemoveLast();
                }

                squares.AddLast(new int[] { i, score });
            }

            return score;
        }
    }
}
