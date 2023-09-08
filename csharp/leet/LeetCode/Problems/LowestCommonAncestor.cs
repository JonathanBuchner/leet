using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.LowestCommonAncestor
{
    /*
     * Lowest Common Ancestor of a Binary Search Tree
     * 
     * iven a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
     * 
     * https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
     */
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            if (Traverse(p, q))
            {
                return p;
            }
            else if (Traverse(q, p))
            {
                return q;
            }
            else
            {
                return Traverse2(root, p, q);
            }
        }

        private bool Traverse(TreeNode root, TreeNode find)
        {
            if (root == null)
            {
                return false;
            }
            else if (root == find)
            {
                return true;
            }

            return Traverse(root.left, find) || Traverse(root.right, find);
        }

        private TreeNode Traverse2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                return root;
            }

            var left = Traverse2(root.left, p, q);
            var right = Traverse2(root.right, p, q);

            if (left == p && right == q || right == p && left == q)
            {
                return root;
            }

            return left ?? right;
        }
    }
}
