using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConvertToTitle
{
    /*
     * Excel Sheet Column Title
     * 
     * Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
     * 
     * https://leetcode.com/problems/excel-sheet-column-title/
     */
    public class Solution
    {
        public string ConvertToTitle(int columnNumber)
        {

            var sb = new StringBuilder();

            while (columnNumber > 0)
            {

                columnNumber -= 1;
                var result = columnNumber % 26;

                sb.Insert(0, Convert.ToChar(result + 'A'));
                columnNumber /= 26;

            }

            //sb.Append(Convert.ToChar(columnNumber - 1 + 'A'));

            return sb.ToString();
        }
    }
}
