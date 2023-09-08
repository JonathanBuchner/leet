using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DiameterOfBinarySearch
{
    /*
     * Diameter of Binary Tree
     * 
     * Given the root of a binary tree, return the length of the diameter of the tree.
     * 
     * The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
     * 
     * The length of a path between two nodes is represented by the number of edges between them.
     * 
     * https://leetcode.com/problems/diameter-of-binary-tree/description/
     */
    public class Solution
    {
        private int longest = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Search(root);

            return longest;
        }

        private int Search(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            var left = Search(root.left);
            var right = Search(root.right);

            ++left;
            ++right;

            longest = Math.Max(longest, left + right);

            return Math.Max(left, right);
        }
    }
}
