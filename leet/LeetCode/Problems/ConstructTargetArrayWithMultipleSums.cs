using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConstructTargetArrayWithMultipleSums
{
    /*
     * Construct Target Array With Multiple Sums
     * 
     * You are given an array target of n integers. From a starting array arr consisting of n 1's, you may perform the following procedure :

     *   let x be the sum of all elements currently in your array.
choose index i, such that 0 <= i < n and set the value of arr at index i to x.

     * You may repeat this procedure as many times as needed.
Return true if it is possible to construct the target array from arr, otherwise, return false.
     * 
     * https://leetcode.com/problems/construct-target-array-with-multiple-sums/
     */
    public class Solution
    {
        public bool IsPossible(int[] target)
        {
            var queue = new PriorityQueue<int, int>();

            var total = 0;

            try
            {
                total = target.Sum();
            }
            catch(OverflowException e)
            {
                return false;
            }
            
            foreach(var num in target)
            {
                queue.Enqueue(num, num * -1);
            }

            if(target.Length == 1)
            {
                return target[0] == 1;  
            }

            while(queue.Peek() > 1)
            {
                var curr = queue.Dequeue();
                var rest = total - curr;

                if (rest == 1)
                {
                    return true;
                }

                var q = curr % rest;

                if(q == 0 || q == curr)
                {
                    return false;
                }

                queue.Enqueue(q, q * -1);
                total = total - curr + q;
            }

            return true;
        }
    }
}
