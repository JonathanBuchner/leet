using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BinaryTree.BinaryTreePreorderTraversal
{
    /*
     * Binary Tree Preorder Traversal
     * 
     * Given the root of a binary tree, return the preorder traversal of its nodes' values.
     * 
     * https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
     */
    public class Solution
    {
        public List<int> values = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            Traverse(root);
            return values;
        }

        private void Traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            values.Add(root.val);

            Traverse(root.left);
            Traverse(root.right);
        }
    }
}
