using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ZigzagConversation
{
    /*
     * Zigzag Conversion
     * 
     * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
     * 
     * https://leetcode.com/problems/zigzag-conversion/
     */
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 0) throw new ArgumentOutOfRangeException("num rows must be at least one");
            if (numRows == 1) return s;
            if (numRows > s.Length) return s;

            var rows = new StringBuilder[numRows];
            for (var i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            var row = 0;
            var countUp = true;

            foreach (char c in s)
            {
                rows[row].Append(c);
                
                if (row == 0)
                {
                    countUp = true;
                }
                else if (row == numRows - 1)
                {
                    countUp = false;
                }

                if (countUp)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            var result = new StringBuilder();

            foreach(var entry in rows)
            {
                result.Append(entry.ToString());
            }

            return result.ToString();
        }
    }
}
