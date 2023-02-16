using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaximumDepthBinaryTree
{
    /*
     * Maximum Depth of Binary Tree
     * 
     * Given the root of a binary tree, return its maximum depth. A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
     * 
     * https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
     */

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MaxDepth(root.left) + 1;
            var right = MaxDepth(root.right) + 1;

            return left > right ? left : right;
        }
    }
}
