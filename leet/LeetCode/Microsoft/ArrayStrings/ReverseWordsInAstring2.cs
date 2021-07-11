using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.ReverseWordsInAstring2
{
    /*
     * Reverse Words in a String II
     * 
     * Given a character array s, reverse the order of the words.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/213/
     */
    public class Solution
    {
        public void ReverseWords(char[] s)
        {
            throw new NotImplementedException();

            var lf = 0;
            var lb = 0;
            var rf = s.Length - 1;
            var rb = s.Length - 1;

            while (lf <= rf)
            {
                var leftIsSpace = Char.IsWhiteSpace(s[lf]);
                var rightIsSpace = Char.IsWhiteSpace(s[rf]);

                if (leftIsSpace && rightIsSpace)
                {
                    var leftWordL = lf - lb;
                    var rightWordL = rb - rf;
                    rf++;
                    lf--;
                    
                    var shorterWordL = Math.Min(leftWordL, rightWordL);
                    for (var i = 0; i < shorterWordL; i++)
                    { 
                        Switch(s, i + lb, i + rf);
                    }
                    
                    var amount = Math.Abs(leftWordL - rightWordL);
                    var rightBound = leftWordL > rightWordL ? rf - 1 : rb;
                    var leftBound = leftWordL > rightWordL ? lb : lf + 1;

                    if (leftWordL != rightWordL)
                    {
                        Slide(s, amount, leftBound, rightBound);
                    }

                    lb = lb + rightWordL + 1;
                    lf = lb;
                    rb = rb - leftWordL - 1;
                    rf = rb;
                }
                else if (leftIsSpace)
                {
                    rf--;
                }
                else if (rightIsSpace)
                {
                    lf++;
                }
                else
                {
                    rf--;
                    lf++;
                }
            }
        }

        private void Switch(char[] s, int i1, int i2)
        {
            var temp = s[i1];
            s[i1] = s[i2];
            s[i2] = temp;
        }

        private void Slide(char[] s, int amt, int leftBound, int rightBound)
        {

            var i = leftBound + amt;
            char prevL = s[leftBound];

            while (true)
            {  
                if (i > rightBound) i = i - rightBound + leftBound;
                var temp = s[i];
                s[i] = prevL;
                prevL = temp;
                if (i == leftBound) break;
                i = i + amt;
            }

            return;
        }
    }
}