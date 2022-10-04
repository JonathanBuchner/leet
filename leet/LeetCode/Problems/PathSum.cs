using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PathSum
{
    /*
     * Path Sum
     * 
     * Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.  A leaf is a node with no children.
     * 
     * https://leetcode.com/problems/path-sum/
     */
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            targetSum -= root.val;

            if (root.left == null && root.right == null)
            {
                return targetSum == 0;
            }

            return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        }
    }
}
