using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDepthBinaryTree
{
    /*
     * Minimum Depth of Binary Tree
     * 
     * Given a binary tree, find its minimum depth.
     * 
     * https://leetcode.com/problems/minimum-depth-of-binary-tree/submissions/
     */
    public class Solution
    {
        public int least = Int32.MaxValue;

        public int MinDepth(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }

            Traverse(root, 0);

            return least;
        }

        private bool Traverse(TreeNode root, int depth)
        {
            if (root == null)
            {
                return true;
            }

            if (depth < least)
            {
                ++depth;
                var l = Traverse(root.left, depth);
                var r = Traverse(root.right, depth);

                if (l & r)
                {
                    least = Math.Min(least, depth);
                }

            }

            return false;
        }
    }
}
