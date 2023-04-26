using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SumOfLeftLeaves
{
    /*
     * Sum of left leaves
     * 
     * Given the root of a binary tree, return the sum of all left leaves.
     * 
     * A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.
     * 
     * https://leetcode.com/problems/sum-of-left-leaves/description/
     */
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {

            var sum = 0;

            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                {
                    sum += root.left.val;
                }
                else
                {
                    sum += SumOfLeftLeaves(root.left);
                }
            }
            if (root.right != null)
            {
                sum += SumOfLeftLeaves(root.right);
            }

            return sum;
        }
    }
}
