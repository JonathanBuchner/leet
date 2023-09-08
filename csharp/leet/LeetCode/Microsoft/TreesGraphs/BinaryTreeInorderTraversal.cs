using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Microsoft.TreesGraphs.BinaryTreeInorderTraversal
{
    /*
     * Binary Tree Inorder Traversal
     * 
     * Given the root of a binary tree, return the inorder traversal of its nodes' values.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/31/trees-and-graphs/153/
     */
    public class Solution
    {
        private List<int> traversal;

        public IList<int> InorderTraversal(TreeNode root)
        {
            traversal = new List<int>();
            Traverse(root);

            return traversal;
        }

        private void Traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left);
            traversal.Add(root.val);
            Traverse(root.right);
        }
    }
}
