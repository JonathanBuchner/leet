﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PutBoxesInTheWareHouseI
{
    /*
     * Put Boxes Into the Warehouse I
     * 
     * You are given two arrays of positive integers, boxes and warehouse, representing the heights of some boxes of unit width and the heights of n rooms in a warehouse respectively. The warehouse's rooms are labelled from 0 to n - 1 from left to right where warehouse[i] (0-indexed) is the height of the ith room
     * 
     * https://leetcode.com/problems/put-boxes-into-the-warehouse-i/
     */
    public class Solution
    {
        public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse)
        {
            Array.Sort(boxes);
            var box = 0;

            var max = Int32.MaxValue;
            for(var i = 0; i < warehouse.Length; ++i)
            {
                max = warehouse[i] = Math.Min(max, warehouse[i]);
            }

            for(var i = warehouse.Length - 1; i >= 0; --i)
            {
                if(boxes[box] <= warehouse[i])
                {
                    box++;

                    if(box == boxes.Length)
                    {
                        break;
                    }
                }
            }

            return box;
        }
    }
}
