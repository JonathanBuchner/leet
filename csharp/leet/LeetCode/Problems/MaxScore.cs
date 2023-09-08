using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaxScore
{
    /*
     * Maximum Points You Can Obtain from Cards
     * 
     * There are several cards arranged in a row, and each card has an associated number of points. The points are given in the integer array cardPoints.
     * 
     * https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
     */
    public class Solution
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            var maxScore = 0;

            if(k >= cardPoints.Length)
            {
                return cardPoints.Sum();
            }

            if(cardPoints.Length == 0)
            {
                throw new ArgumentException("Cardpoints must contain at least one number");
            }

            if (k == 0)
            {
                throw new ArgumentException("There must be at least one card selected");
            }


            for (var i = cardPoints.Length - k; i < cardPoints.Length; ++i)
            {
                maxScore += cardPoints[i];
            }


            var curr = maxScore;
            for(var i = 0; i < k - 1; ++i)
            {
                curr += cardPoints[i] - cardPoints[cardPoints.Length - k + i];
                maxScore = Math.Max(maxScore, curr);
            }

            var front = curr + cardPoints[k-1] - cardPoints[cardPoints.Length-1];


            return Math.Max(maxScore, front);
        }
    }
}
