using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {

            int num = Int32.MinValue;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    num = nums[i];
                    count = 1;
                }
                else
                {
                    if (num == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                        if (count == 0)
                        {
                            num = nums[i];
                            count = 1;
                        }
                    }
                }
            }

            return num;
        }
    }
}
