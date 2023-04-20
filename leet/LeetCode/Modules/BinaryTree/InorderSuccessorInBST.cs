using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BinaryTree.InorderSuccessorInBST
{
    /*
     * Inorder Successor in BST
     * 
     * Given the root of a binary search tree and a node p in it, return the in-order successor of that node in the BST. If the given node has no in-order successor in the tree, return null.
     * 
     * The successor of a node p is the node with the smallest key greater than p.val.
     * 
     * https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/140/introduction-to-a-bst/998/
     */
    public class Solution
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            return FindSuccessor(root, p, null);
        }

        private TreeNode FindSuccessor(TreeNode root, TreeNode p, TreeNode c)
        {

            if (root.val == p.val + 1)
            {
                return root;
            }

            if (root.val > p.val + 1)
            {
                c = root;

                if (root.left == null)
                {
                    return c;
                }
                else
                {
                    return FindSuccessor(root.left, p, c);
                }
            }
            else
            {
                if (root.right == null)
                {
                    return c;
                }
                else
                {
                    return FindSuccessor(root.right, p, c);
                }
            }

        }
    }
}
