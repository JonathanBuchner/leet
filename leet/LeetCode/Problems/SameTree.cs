using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SameTree
{
    /*
     * Same Tree
     * 
     * Given the roots of two binary trees p and q, write a function to check if they are the same or not.  Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
     * 
     * https://leetcode.com/problems/same-tree/description/
     */
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
            {
                return p == null && q == null;
            }

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
