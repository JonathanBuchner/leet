using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FlattenBinaryTreeToLinkedList
{
    /*
     * Flatten Binary Tree to Linked List
     * 
     * Given the root of a binary tree, flatten the tree into a "linked list":

     *   The "linked list" should use the same TreeNode class where the right child pointer points to the next node in the list and the left child pointer is always null.
     *   The "linked list" should be in the same order as a pre-order traversal of the binary tree.
     * 
     * https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
     */
    public class Solution
    {
        public void Flatten(TreeNode root)
        {

            if (root == null)
            {
                return;
            }

            var queue = new Stack<TreeNode>();
            queue.Push(root);

            while (queue.Count > 0)
            {
                var curr = queue.Pop();

                if (curr.right != null)
                {
                    queue.Push(curr.right);
                }

                if (curr.left != null)
                {
                    queue.Push(curr.left);
                }

                if (queue.Count > 0)
                {
                    curr.right = queue.Peek();
                }
                else
                {
                    curr.right = null;
                }

                curr.left = null;
            }
        }
    }
}
