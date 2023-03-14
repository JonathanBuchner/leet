using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Microsoft.TreesGraphs
{
    /*
     * Binary Tree Level Order Traversal
     * 
     * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
     * 
     * https://leetcode.com/explore/interview/card/microsoft/31/trees-and-graphs/164/
     */
    public class Solution
    {
        private List<IList<int>> list = new List<IList<int>>();
        private int maxlevel = -1;

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Traverse(root, 0);

            return list;
        }

        private void Traverse(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }

            if (level > maxlevel)
            {
                list.Add(new List<int>());
                maxlevel++;
            }

            list[level].Add(root.val);
            level++;

            Traverse(root.left, level);
            Traverse(root.right, level);
        }
    }
}
