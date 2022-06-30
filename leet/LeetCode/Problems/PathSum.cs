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

            return Traverse(root, targetSum, 0);

        }

        private bool Traverse(TreeNode node, int targetSum, int sum)
        {
            if (node == null)
            {
                return false;
            }

            sum += node.val;

            if (node.left == null && node.right == null)
            {
                Console.WriteLine($"Target = {targetSum} ;  Sum = {sum}.");

                if (sum == targetSum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return Traverse(node.left, targetSum, sum) || Traverse(node.right, targetSum, sum);
        }
    }
}
