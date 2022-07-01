using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace leet.LeetCode.Microsoft.LongestHappyString
{
    /*
      * Longest Happy String
      * 
      * Given three integers a, b, and c, return the longest possible happy string. If there are multiple longest happy strings, return any of them. If there is no such string, return the empty string ""
      * 
      * https://leetcode.com/problems/longest-happy-string/
      */
    public class Solution
    {
        private int A;
        private int B;
        private int C;
        private char prev;
        private StringBuilder sb = new StringBuilder();

        public string LongestDiverseString(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            prev = A < B && A < C ?
                'a' :
                B < C ?
                    'b' :
                    'c'; 
                    

            while (A > 0 || B > 0 || C > 0)
            {
                if(prev == 'a')
                {
                    if (B > C)
                    {
                        HandleCase('b');

                    }
                    else
                    {
                        HandleCase('c');
                    }
                } 
                else if (prev == 'b')
                {
                    if (A > C)
                    {
                        HandleCase('a');
                    }
                    else
                    {
                        HandleCase('c');
                    }
                } 
                else
                {
                    if (A > B)
                    {
                        HandleCase('a');
                    }
                    else
                    {
                        HandleCase('b');
                    }
                }
            }

            return sb.ToString();
        }

        private void HandleCase(char character)
        {
            switch(character)
            {
                case 'a':
                    var am = Math.Min(2, A);

                    if (am == 1)
                    {
                        sb.Append('a');
                        A--;
                    }
                    else if (am == 2)
                    {
                        sb.Append("aa");
                        A -= 2;
                    }

                    prev = 'a';
                    break;
                case 'b':
                    
                    var bm = Math.Min(2, B);

                    if (bm == 1)
                    {
                        sb.Append('b');
                        --B;
                    }
                    else if (bm == 2)
                    {
                        sb.Append("bb");
                        B -= 2;
                    }

                    prev = 'b';
                    break;

                case 'c':
                    var cm = Math.Min(2, C);

                    if (cm == 1)
                    {
                        sb.Append('c');
                        C--;
                    }
                    else if (cm == 2)
                    {
                        sb.Append("cc");
                        C -= 2;
                    }
                    prev = 'c';

                    break;

                default:

                    throw new ArgumentException("Must provide a character");
                   
            }
        }
    }
}
