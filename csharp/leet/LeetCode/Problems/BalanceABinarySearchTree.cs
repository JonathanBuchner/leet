using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BalanceABinarySearchTree
{
    public class Solution
    {
        public TreeNode BalanceBST(TreeNode root)
        {
            var vals = new List<int>();

            Traverse(root, vals);

            vals.Sort();

            var result = CreateNode(vals);

            return result;
        }

        private void Traverse(TreeNode root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left, list);
            Traverse(root.right, list);

            list.Add(root.val);

            return;
        }

        private TreeNode CreateNode(List<int> list)
        {
            if (list.Count == 0)
            {
                return null;
            }

            var middle = list.Count / 2;
            var lower_count = middle;
            var upper = middle + 1;
            var upper_count = list.Count - upper;

            TreeNode left = null;
            TreeNode right = null;
            
            if (lower_count > 0)
            {
                left = CreateNode(list.GetRange(0, lower_count));
            }

            if (upper_count > 0)
            {
                right = CreateNode(list.GetRange(upper, upper_count));
            }

            return new TreeNode(list[middle], left, right);
        }
        
    }

}
