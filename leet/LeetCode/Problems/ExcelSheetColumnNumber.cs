using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ExcelSheetColumnNumber
{
    /*
     * Excel Sheet Column Number
     * 
     * Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number
     * 
     * https://leetcode.com/problems/excel-sheet-column-number/
     */
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            double total = 0;

            for(var i = 0; i < columnTitle.Length; i++)
            {
                total += (columnTitle[i] - 'A' + 1) * Math.Pow(26, columnTitle.Length - i - 1);
            }

            return Convert.ToInt32(total);
        }
    }
}
