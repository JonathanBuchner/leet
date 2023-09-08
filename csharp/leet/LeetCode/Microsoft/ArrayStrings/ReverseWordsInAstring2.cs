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
        private char[] s;
        private int endIndex;

        public void ReverseWords(char[] s)
        {
            this.s = s;
            endIndex = s.Length - 1;

            Run();
        }

        private void Run()
        {
            while (endIndex >= 0)
            {
                var nextWordLastLetterIndex = GetNextWordLength() - 1;
                if (nextWordLastLetterIndex >= endIndex) return;

                ShiftWord(nextWordLastLetterIndex);
                CorrectSpaceing();
            }
        }

        private int GetNextWordLength()
        {
            var counter = 0;
            
            while(counter <= endIndex && !Char.IsWhiteSpace(s[counter]))
            {
                counter++;
            }

            return counter;
        }

        private void ShiftWord(int lastLetterIndex)
        {
            for(var i = lastLetterIndex; i >= 0; i--)
            {
                ShiftLettersLeft(i);
            }
        }

        private void CorrectSpaceing()
        {
            if (Char.IsWhiteSpace(s[0]))
            {
                ShiftLettersLeft(0);
            }
        }

        private void ShiftLettersLeft(int startIndex)
        {
            var swap = s[startIndex];

            for(var i = endIndex; i >= startIndex; i--)
            {
                var temp = s[i];
                s[i] = swap;
                swap = temp;
            }

            endIndex--;
        }

    }
}