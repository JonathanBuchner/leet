using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumHealthToBeatGame
{
    /*
     * Minimum Health to Beat Game
     * 
     * You are playing a game that has n levels numbered from 0 to n - 1. You are given a 0-indexed integer array damage where damage[i] is the amount of health you will lose to complete the ith level.  You are also given an integer armor. You may use your armor ability at most once during the game on any level which will protect you from at most armor damage.  You must complete the levels in order and your health must be greater than 0 at all times to beat the game.  Return the minimum health you need to start with to beat the game.
     * 
     * https://leetcode.com/problems/minimum-health-to-beat-game/description/
     */
    public class Solution
    {
        public long MinimumHealth(int[] damage, int armor)
        {
            int hDamage = 0;
            Int64 tDamage = 0;

            for (var i = 0; i < damage.Length; i++)
            {
                tDamage += damage[i];
                hDamage = Math.Max(hDamage, damage[i]);
            }

            return tDamage - Math.Min(hDamage, armor) + 1;
        }
    }
}
