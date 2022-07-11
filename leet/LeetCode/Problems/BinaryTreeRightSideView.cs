using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreeRightSideView
{
    /*
     * Binary Tree Right Side View
     * 
     * Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
     * 
     * https://leetcode.com/problems/binary-tree-right-side-view/
     */
    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var rightView = new List<int>();
            var level = 0;

            Traverse(root, rightView, level);

            return rightView;

        }

        private void Traverse(TreeNode root, IList<int> rightView, int level)
        {
            if(root == null)
            {
                return;
            }

            if (rightView.Count <= level)
            {
                rightView.Add(root.val);
            }

            Traverse(root.right, rightView, level + 1);
            Traverse(root.left, rightView, level + 1);

        }
    }
}
