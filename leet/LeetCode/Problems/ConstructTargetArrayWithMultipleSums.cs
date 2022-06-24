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
            Array.Sort(target);
            var start = new int[target.Length];
            var queue = new Queue<int[]>();

            for (int i = 0; i < target.Length; i++)
            {
                start[i] = 1;
            }
            queue.Enqueue(start);

            for(var i = 0; i < target.Length; i++)
            {
                var t = target[i];
                var answers = new Queue<int[]>();

                while(queue.Count > 0)
                {
                    var q = queue.Dequeue();
                    var total = q.Sum();

                    if (q[i] == t)
                    {
                        answers.Enqueue(q);
                    }
                    else if (total > t)
                    {
                        continue;
                    }
                    else
                    {
                        for (var k = i; k < q.Length; k++)
                        {
                            var arr = new int[q.Length];
                            Array.Copy(q, 0, arr, 0, q.Length);
                            arr[k] = total;
                            queue.Enqueue(arr);
                        }
                    }
                }

                if(answers.Count == 0)
                {
                    return false;
                }

                queue = answers;
            }

            return true;
        }
    }
}
