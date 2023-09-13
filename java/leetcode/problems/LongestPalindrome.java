/*
* Longest Palindrome
* 
* @author Jonathan Buchner
* 
* Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.
*
* https://leetcode.com/problems/longest-palindrome/description/
*/

import java.util.HashSet; 

class LongestPalindrome {
    public int longestPalindrome(String s) {
        var hashset = new HashSet<Character>();
        var length = 0;

        for (var i = 0; i < s.length(); i++)
        {
            if (hashset.contains(s.charAt(i)))
            {
                length += 2;
                hashset.remove(s.charAt(i));
            }
            else
            {
                hashset.add(s.charAt(i));
            }
        }

        // If there is at least one remaining char that can be used in the middle
        if (s.length() > length)
        {
            length++;
        }
        
        return length;
    }
}