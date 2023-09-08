using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RemoveStonestoMinimizetheTotal
{
    /*
     * Remove Stones to Minimize the Total
     * 
     * You are given a 0-indexed integer array piles, where piles[i] represents the number of stones in the ith pile, and an integer k. You should apply the following operation exactly k times:
     *      Choose any piles[i] and remove floor(piles[i] / 2) stones from it.
     * Notice that you can apply the operation on the same pile more than once.
     * 
     * Return the minimum possible total number of stones remaining after applying the k operations.
     * 
     * https://leetcode.com/problems/remove-stones-to-minimize-the-total/description/
     */
    public class Solution
    {
        public int MinStoneSum(int[] piles, int k)
        {
            //PriorityQueue<[pilehieght, originalindex], pilehieght>
            var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            for (var i = 0; i < piles.Length; i++)
            {
                queue.Enqueue(piles[i], piles[i]);
            }

            for (var i = 0; i < k; i++)
            {
                var pile = queue.Dequeue();
                var half = pile - pile / 2;
                queue.Enqueue(half, half);
            }

            var unorderedpiles = queue.UnorderedItems;
            var total = 0;
            foreach (var pile in unorderedpiles)
            {
                total += pile.Element;
            }

            return total;
        }
    }
}
