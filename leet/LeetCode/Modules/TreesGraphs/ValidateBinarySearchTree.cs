using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.TreesGraphs.ValidateBinarySearchTree
{
    /*
     * Validate Binary Search Tree
     * 
     * Given the root of a binary tree, determine if it is a valid binary search tree (BST).
     * 
     * https://leetcode.com/problems/validate-binary-search-tree/description/
     */
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, null, null);
        }

        private bool Validate(TreeNode root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val <= min)
            {
                return false;
            }

            if (root.val >= max)
            {
                return false;
            }

            return Validate(root.left, min, root.val) && Validate(root.right, root.val, max);
        }
    }
}
