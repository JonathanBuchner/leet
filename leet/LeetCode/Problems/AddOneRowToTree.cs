using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.AddOneRowToTree
{
    /*
     * Add One Row to Tree
     * 
     * Given the root of a binary tree and two integers val and depth, add a row of nodes with value val at the given depth depth.
     * 
     * https://leetcode.com/problems/add-one-row-to-tree/description/
     */
    public class Solution
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                return new TreeNode(val, root);
            }

            Insert(root, val, depth);

            return root;
        }

        private void Insert(TreeNode root, int val, int depth)
        {
            if (root == null)
            {
                return;
            }

            depth--;

            if (depth == 1)
            {
                root.left = new TreeNode(val, root.left, null);
                root.right = new TreeNode(val, null, root.right);
                return;
            }

            AddOneRow(root.left, val, depth);
            AddOneRow(root.right, val, depth);
        }
    }
}
