using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems
{
    /*
     * Read N Characters Given Read4
     * 
     * Given a file and assume that you can only read the file using a given method read4, implement a method to read n characters.
     * 
     * https://leetcode.com/problems/read-n-characters-given-read4/
     * 
     * Did not complete.  Too confusing. Too much time to make Reader4 for testing.
     */
     
    
    /*public class Solution : Reader4
    {
        public int Read(char[] buf, int n)
        {
            var copiedChars = 0;
            var readChars = 4;
            var buf4 = new char[4];

            while (copiedChars < n && readChars == 4)
            {
                readChars = Read4(buf4);

                for (int i = 0; i < readChars; ++i)
                {
                    if (copiedChars == n)
                        return copiedChars;
                    buf[copiedChars] = buf4[i];
                    ++copiedChars;
                }
            }
            return copiedChars;
        }
    }*/
}
