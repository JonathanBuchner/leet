using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreeLongestConsecutiveSequence
{
    /*
     * Binary Tree Longest Consecutive Sequence
     * 
     * Given the root of a binary tree, return the length of the longest consecutive sequence path. A consecutive sequence path is a path where the values increase by one along the path. Note that the path can start at any node in the tree, and you cannot go from a node to its parent in the path.
     * 
     * https://leetcode.com/problems/binary-tree-longest-consecutive-sequence/
     */

    public class Solution
    {
        public int LongestConsecutive(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            return Traverse(root, 1);
        }

        public int Traverse(TreeNode root, int streak)
        {
            var left = 0;
            var right = 0;

            if (root.left != null)
            {
                var streakLeft = 0;
                if (root.left.val == root.val +1)
                {
                    streakLeft = root.val + 1;
                }
                left = Traverse(root.left, streakLeft);
            }
            
            if (root.right != null)
            {
                var streakRight = 0;
                if (root.right.val == root.val + 1)
                {
                    streakRight = root.val + 1;
                }
                right = Traverse(root.left, streakRight);
            }

            return Math.Max(Math.Max(right, left), streak);
        }
    }
}
