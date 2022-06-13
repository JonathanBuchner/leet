using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace leet.LeetCode.Problems.Pascals_Triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var answer = new List<IList<int>>();

            if(numRows > 0)
            {
                answer.Add(new List<int>() { 1 });
            }

            if (numRows > 1)
            {
                answer.Add(new List<int>() { 1, 1 });
            }

            for (var i = 2; i < numRows; i++)
            {
                var row = new List<int>() { 1 };
                
                for(var k = 1; k < i; k++)
                {
                    row.Add(answer[i - 1][k-1] + answer[i - 1][k]);
                }

                row.Add(1);
                answer.Add(row);
            }

            return answer;
        }
    }
}
