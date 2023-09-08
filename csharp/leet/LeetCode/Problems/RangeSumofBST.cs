using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.RangeSumofBST
{
    /*
     * Range Sum of BST
     * 
     * Given the root node of a binary search tree and two integers low and high, return the sum of values of all nodes with a value in the inclusive range [low, high].
     * 
     * https://leetcode.com/problems/range-sum-of-bst/
     */
    public class Solution
    {
        private int total;
        private int low;
        private int high;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            total = 0;
            this.low = low;
            this.high = high;

            CheckTree(root);

            return total;
        }

        private void CheckTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            if (root.val >= low && root.val <= high)
            {
                total += root.val;
            }

            CheckTree(root.left);
            CheckTree(root.right);
        }
    }
}
