using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.BinaryTreeCovers
{
    /*
     * Binary Tree Cameras
     * 
     * You are given the root of a binary tree. We install cameras on the tree nodes where each camera at a node can monitor its parent, itself, and its immediate children.
     * 
     * Return the minimum number of cameras needed to monitor all nodes of the tree.
     * 
     * https://leetcode.com/problems/binary-tree-cameras/
     */
    public class Solution
    {
        public int MinCameraCover(TreeNode root)
        {
            var answer = CheckNodeForCamera(root);
            
            if (answer[0] == 1)
            {
                answer[1]++;
            }

            return answer[1];
        }

        private int[] CheckNodeForCamera(TreeNode root)
        {
            if (root == null)
            {
                return new int[] { 0, 0 };
            }

            var camsL = CheckNodeForCamera(root.left);
            var camsR = CheckNodeForCamera(root.right);

            if (camsL[0] == 1 || camsR[0] == 1)
            {
                return new int[] { 2, camsL[1] + camsR[1] + 1 };
            }
            else if (camsL[0] == 2 || camsR[0] == 2)
            {
                return new int[] { 0, camsL[1] + camsR[1] };
            }
            else
            {
                return new int[] { 1, camsL[1] + camsR[1] };
            }
        }
    }
}
