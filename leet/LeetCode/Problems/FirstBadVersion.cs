using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FirstBadVersion
{
    /*
     * First Bad Version
     * 
     * You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad. 
     * 
     * Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
     * 
     * You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
     * 
     * https://leetcode.com/problems/first-bad-version/description/
     * 
     *  This solution will not correctly run as is because IsBadVersion does note exist.
     */
    public class Solution
    {
        public int FirstBadVersion(int n)
        {
            var low = 0;

            while (low < n)
            {
                var middle = low + ((n - low) / 2);

                if (IsBadVersion(middle))
                {
                    n = middle;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return low;
        }
        private bool IsBadVersion(int number)
        {
            return true;
        }
    }

}
