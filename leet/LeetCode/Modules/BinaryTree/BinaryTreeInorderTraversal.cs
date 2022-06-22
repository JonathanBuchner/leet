using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BinaryTree.BinaryTreeInorderTraversal
{
    /*
     * Binary Tree Inorder Traversal
     * 
     * Given the root of a binary tree, return the inorder traversal of its nodes' values.
     * 
     * https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/929/
     */
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();

            Dfa(root, list);

            return list;
        }

        private void Dfa(TreeNode node, List<int> list)
        {
            if (node != null)
            {
                Dfa(node.left, list);
                list.Add(node.val);
                Dfa(node.right, list);
            }
        }
    }
}
