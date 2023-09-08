using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreelevelOrderTraversal
{
    /*
     * Binary Tree Level Order Traversal
     * 
     * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
     * 
     * https://leetcode.com/problems/binary-tree-level-order-traversal/
     */
    public class Solution
    {
        private List<IList<int>> lists = new List<IList<int>>();
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var level = 0;
            Traverse(root, level);

            return lists;
        }

        private void Traverse(TreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (lists.Count <= level)
            {
                lists.Add(new List<int>());
            }

            lists[level].Add(node.val);

            ++level;
            Traverse(node.left, level);
            Traverse(node.right, level);

        }
    }
}
