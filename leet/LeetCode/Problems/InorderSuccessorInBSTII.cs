using leet.LeetCode.Models.NodeParent;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.InorderSuccessorInBSTII
{
    /*
     * Inorder Successor in BST II
     * 
     * Given a node in a binary search tree, return the in-order successor of that node in the BST. If that node has no in-order successor, return null.
     * 
     * https://leetcode.com/problems/inorder-successor-in-bst-ii/
     */
    public class Solution
    {
        public Node InorderSuccessor(Node x)
        {
            if (x.right != null)
            {
                x = x.right;
                while (x.left != null)
                {
                    x = x.left;
                }
                return x;
            }

            while (x.parent != null && x == x.parent.right)
            {
                x = x.parent;
            }

            return x.parent;
        }
    }
}
