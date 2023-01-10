using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreePreorderTraversal
{
    /*
     * Binary Tree Preorder Traversal
     * 
     * Given the root of a binary tree, return the preorder traversal of its nodes' values.
     * 
     * https://leetcode.com/problems/binary-tree-preorder-traversal/description/
     */
    public class Solution
    {
        private List<int> preorder = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            Traverse(root);

            return preorder;
        }

        private void Traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            preorder.Add(root.val);
            Traverse(root.left);
            Traverse(root.right);
        }
    }
}
