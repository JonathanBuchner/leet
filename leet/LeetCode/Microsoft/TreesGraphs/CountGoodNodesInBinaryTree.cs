using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.TreesGraphs.CountGoodNotesBiaryTree
{
    /*
     * Count Good Nodes in Binary Tree
     * 
     * Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.  Return the number of good nodes in the binary tree.
     * 
     * https://leetcode.com/problems/count-good-nodes-in-binary-tree/
     */
    public class Solution
    {
        public int GoodNodes(TreeNode root)
        {
            return Traverse(root, int.MinValue);
        }

        private int Traverse(TreeNode root, int highest)
        {
            if (root == null)
            {
                return 0;
            }

            var count = 0;

            if (root.val >= highest)
            {
                highest = root.val;
                count++;
            }

            var leftCount = Traverse(root.left, highest);
            var rightCount = Traverse(root.right, highest);

            return count + leftCount + rightCount;
        }
    }
}
