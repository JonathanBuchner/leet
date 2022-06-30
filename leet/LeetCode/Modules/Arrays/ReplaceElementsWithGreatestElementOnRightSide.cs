﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.ReplaceElementsWithGreatestElementOnRightSide
{
    /*
     * Replac eElements With Greatest Element On Right Side
     * 
     * Replace Elements with Greatest Element on Right Side
     * Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/511/in-place-operations/3259/
     */

    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            var highest = -1;

            for(var i = arr.Length - 1; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = highest;
                
                highest = Math.Max(highest, temp);
            }

            return arr;
        }
    }
}
