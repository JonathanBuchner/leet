using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.InvertBinaryTree
{
    /*
     * Invert Binary Tree
     * 
     * Given the root of a binary tree, invert the tree, and return its root.
     * 
     * https://leetcode.com/problems/invert-binary-tree/
     */
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            InvertTree(root.left);
            InvertTree(root.right);

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            return root;
        }
    }
}
