using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ClosestBinarySearchTreeValue
{
    /*
     * Closest Binary Search Tree Value
     * 
     * Given the root of a binary search tree and a target value, return the value in the BST that is closest to the target.
     * 
     * https://leetcode.com/problems/closest-binary-search-tree-value/description/
     */
    public class Solution
    {
        public int ClosestValue(TreeNode root, double target)
        {
            var closest = root.val;
            var tar = (int)Math.Round(target);

            while (root != null)
            {
                closest = Math.Abs(target - closest) < Math.Abs(target - root.val) ? closest : root.val;

                if (closest == tar)
                {
                    return closest;
                }

                root = root.val < target ? root.left : root.right;
            }

            return closest;
        }
    }
}
