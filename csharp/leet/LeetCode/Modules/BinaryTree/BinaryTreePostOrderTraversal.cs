using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BinaryTree.BinaryTreePostOrderTraversal
{
    /*
     * Binary Tree Postorder Traversal
     * 
     * Given the root of a binary tree, return the postorder traversal of its nodes' values.
     * 
     * https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
     */
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var list  = new List<int>();

            Traverse(root, list);

            return list;
        }

        private void Traverse(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left, list);
            Traverse(root.right, list);
            list.Add(root.val);
        }
    }
}
