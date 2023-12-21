using System;

namespace leet.LeetCode.Problems.CountBits;
/**
* Counting Bits
* 
* Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), 
* ans[i] is the number of 1's in the binary representation of i.
* 
* https://leetcode.com/problems/counting-bits/
*/
public class Solution {
    public int[] CountBits(int n) {
        var arr = new int[n + 1];

        for (var i = 1; i < arr.Length; i++) {
            arr[i] = i % 2 + arr[i >> 1];
        }

        return arr;
    }
}

