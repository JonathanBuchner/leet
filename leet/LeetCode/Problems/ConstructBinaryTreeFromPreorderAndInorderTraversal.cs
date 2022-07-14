using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    /*
     * Construct Binary Tree from Preorder and Inorder Traversal
     * 
     * Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
     * 
     * https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
     */
    public class Solution
    {
        private int i = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (inorder.Length == 0)
            {
                return null;
            }
            
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < inorder.Length; ++i)
            {
                dict.Add(inorder[i], i);
            }

            var node = Build(preorder, 0, preorder.Length - 1, dict); 

            return node;
        }

        private TreeNode Build(int[] preorder, int left, int right, Dictionary<int, int> dict)
        {
            if (left > right)
            {
                return null;
            }

            var val = preorder[i++];
            var index = dict[val];

            var node = new TreeNode(val);

            node.left = Build(preorder, left, index - 1, dict);
            node.right = Build(preorder, index + 1, right, dict);

            return node;
        }
    }
}
