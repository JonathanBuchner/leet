using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DecodeTheSlantedCiphertext
{
    public class Solution
    {
        public string DecodeCiphertext(string encodedText, int rows)
        {
            if (encodedText.Length == 0)
            {
                return "";
            }

            var cols = encodedText.Length / rows;
            var result = new StringBuilder();

            for (var i = 0; i < cols; i++)
            {
                var start = i;
                while (start < encodedText.Length)
                {
                    result.Append(encodedText[start]);
                    start += cols + 1;
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
