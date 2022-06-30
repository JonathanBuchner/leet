using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PartitionIntoMinimumNumverOfDeciBinaryNumbers
{
    /*
     * Partitioning Into Minimum Number Of Deci-Binary Numbers
     * 
     * A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros. For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.
     * 
     * 
     * https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
     */
    public class Solution
    {
        public int MinPartitions(string n)
        {
            var highest = 0;

            if(n == null)
            {
                return highest;
            }

            foreach (char c in n)
            {
                highest = Math.Max(highest, c - '0');
            }

            return highest;
        }
    }
}
