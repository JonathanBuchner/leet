using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SymmetricTree
{
    /*
     * Symmetric Tree
     * 
     * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
     * 
     * https://leetcode.com/problems/symmetric-tree/
     */
    public class Solution
    {
        private List<List<int>> left = new List<List<int>>();
        private List<List<int>> right = new List<List<int>>();

        public bool IsSymmetric(TreeNode root)
        {

            if (root == null)
            {
                return false;
            }

            TraverseLeft(root.left, 0);
            TraverseRight(root.right, 0);

            if (left.Count != right.Count)
            {
                return false;
            }

            for (var i = 0; i < left.Count; i++)
            {
                if (left[i].Count != right[i].Count)
                {
                    return false;
                }

                for (var k = 0; k < left[i].Count; k++)
                {
                    Console.WriteLine($"LEFT: {left[i][k]}. RIGHT: {right[i][k]}. ");
                    if (left[i][k] != right[i][k])
                    {
                        return false;
                    }
                }
            }

            return true;

        }

        private void TraverseLeft(TreeNode root, int level)
        {

            if (left.Count <= level)
            {
                left.Add(new List<int>() { });
            }

            if (root == null)
            {
                left[level].Add(-1000);
                return;
            }

            left[level].Add(root.val);
            ++level;
            TraverseLeft(root.left, level);
            TraverseLeft(root.right, level);

        }

        private void TraverseRight(TreeNode root, int level)
        {
            if (right.Count <= level)
            {
                right.Add(new List<int>() { });
            }

            if (root == null)
            {
                right[level].Add(-1000);
                return;
            }

            right[level].Add(root.val);
            ++level;
            TraverseRight(root.right, level);
            TraverseRight(root.left, level);
        }
    }
}
