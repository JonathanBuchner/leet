using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDistanctBetweenBSTNodes
{
    /*
     * Minimum Distance Between BST Nodes
     * 
     * Given the root of a Binary Search Tree (BST), return the minimum difference between the values of any two different nodes in the tree.
     * 
     * https://leetcode.com/problems/minimum-distance-between-bst-nodes/description/
     */
    public class Solution
    {
        private List<int> list = new List<int>();

        public int MinDiffInBST(TreeNode root)
        {
            PopulateList(root);

            list.Sort();

            var min = Int32.MaxValue;
            for (var i = 0; i < list.Count - 1; i++)
            {
                min = Math.Min(list[i + 1] - list[i], min);
            }

            return min;
        }

        private void PopulateList(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            list.Add(root.val);

            PopulateList(root.left);
            PopulateList(root.right);
        }
    }
}
