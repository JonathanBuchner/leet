using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.HeightChecker
{
    /*
     * Height Checker
     * 
     * A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.
     * 
     * You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).
     * 
     * Return the number of indices where heights[i] != expected[i].
     * 
     * https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
     */
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            var sorted = new int[heights.Length];
            heights.CopyTo(sorted, 0);

            mergeSort(sorted, 0, sorted.Length - 1);

            var count = 0;
            for(var i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sorted[i]) count++;
            }

            return count;
        }

        public void mergeSort(int[] arr, int begin, int end)
        {
            if (end - begin < 1)
            {
                return;
            }
            else if (end - begin < 2)
            {
                if (arr[begin] > arr[end])
                {
                    var temp = arr[end];
                    arr[end] = arr[begin];
                    arr[begin] = temp;
                }
            } 
            else
            {
                var middle = ((end - begin) / 2);
                mergeSort(arr, begin, middle);
                mergeSort(arr, middle + 1, end);

                var bot = new int[middle - begin + 1];
                var top = new int[end - middle];
                Array.Copy(arr, begin, bot, 0, middle - begin);
                Array.Copy(arr, begin, top, 0, end - (middle + 1));

                var b = 0;
                var t = 0;

                while(b < bot.Length && t < top.Length)
                {
                    if (t >= top.Length || bot[b] > top[t])
                    {
                        arr[begin] = top[t];
                        t++;
                    }
                    else
                    {
                        arr[begin] = bot[b];
                        b++;
                    }
                    begin++;
                }
            }
        }
    }
}
