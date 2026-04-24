using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MirrorDistanceOfAnInteger
{
    /**
     * Mirror Distance of an Integer
     * 
     * https://leetcode.com/problems/mirror-distance-of-an-integer/description
     */
    public class Solution
    {
        public int MirrorDistance(int n)
        {
            return Math.Abs(n - ReverseInt(n));
        }

        private int ReverseInt(int num)
        {
            var result = 0;
            
            while (num != 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }

            return result;
        }
    }
}
