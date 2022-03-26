using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace leet.LeetCode.Problems.JumpGame3
{
    public class Solution
    {
        private BitArray check;
        private int[] arr;
        public bool CanReach(int[] arr, int start)
        {
            check = new BitArray(arr.Length, false);
            this.arr = arr;

            return Look(start);
        }

        public bool Look(int index)
        {
            if(arr[index] == 0)
            {
                return true;
            }
            else if(check[index] == true)
            {
                return false;
            } 
            else
            {
                check[index] = true;
            }

            if(index - arr[index] >= 0)
            {

                if (Look(index - arr[index]))
                {
                    return true;
                }

            }

            if(index + arr[index] < arr.Length)
            {
                if (Look(index + arr[index]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
