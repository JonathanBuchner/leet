using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems
{
    /*
     * Balanced Binary Tree
     * 
     * Given a binary tree, determine if it is height-balanced. For this problem, a height-balanced binary tree is defined as: a binary tree in which the left and right subtrees of every node differ in height by no more than 1.
     * 
     * 
     * https://leetcode.com/problems/balanced-binary-tree/
     */
    public class Solution
    {
        private bool answer = true;


        public bool IsBalanced(TreeNode root)
        {

            if (root == null)
            {
                return true;
            }

            Traverse(root, 0);

            return answer;
        }

        private int Traverse(TreeNode root, int level)
        {
            if (root == null)
            {
                return level;
            }

            ++level;

            var left = Traverse(root.left, level);

            if (!answer)
            {
                return left;
            }

            var right = Traverse(root.right, level);

            Console.WriteLine($"Left: {left}.  Right: {right}");

            if (Math.Abs(left - right) > 1)
            {
                answer = false;
            }

            return Math.Max(right, left);
        }
    }
}
