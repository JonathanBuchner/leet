using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FurthestPointFromOrigin
{
    public class Solution
    {
        public int FurthestDistanceFromOrigin(string moves)
        {
            var left = 0;
            var right = 0;
            var wild = 0;

            for (var i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L')
                    left++;
                else if (moves[i] == 'R')
                    right++;
                else if (moves[i] == '_')
                    wild++;
                else
                    throw new ArgumentException($"Unrecognized character in string. Character : {moves[i]}");
            }


            return Math.Abs(left - right) + wild;
        }
    }
}
