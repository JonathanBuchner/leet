/**
 * Valid word square
 * 
 * Given an array of strings words, return true if it forms a valid word square.
 * 
 * A sequence of strings forms a valid word square if the kth row and column read the same string, where 0 <= k < max(numRows, numColumns).
 * 
 * https://leetcode.com/problems/valid-word-square/
 */

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class ValidWordSquare
{
    public static void main(String[] args)
    {
        List<String> testinput = new ArrayList<String>(Arrays.asList("abcd","bnrt","crmy","dtye"));
        var test1 = new Solution().validWordSquare(testinput);
        System.out.println(test1);
    }
}
 

// In progress
class Solution {
    public boolean validWordSquare(List<String> words) {
        var r = 0;
        var c = 1;

        while (r < words.size())
        {
            var rowlength = words.get(r).length();
            
            if (rowlength > words.size() && r < words.get(rowlength).length())
            {

            }

            while ( c < rowlength)
            {
                if (words.get(r).charAt(c) != words.get(c).charAt(r))
                {
                    return false;
                }
                
                c++;
            }

            r++;
        }

        return true;
    }
}