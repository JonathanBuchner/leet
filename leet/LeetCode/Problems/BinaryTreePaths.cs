using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinaryTreePaths
{
    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return new List<string>()
            {
                $"{root.val}"
            };
            }

            List<string> left;
            List<string> right;


            if (root.left != null)
            {
                left = (List<string>)BinaryTreePaths(root.left);

                for (var i = 0; i < left.Count; i++)
                {
                    left[i] = String.Concat(root.val, "->", left[i]);
                }
            }
            else
            {
                left = new List<string>();
            }

            if (root.right != null)
            {
                right = (List<string>)BinaryTreePaths(root.right);

                for (var i = 0; i < right.Count; i++)
                {
                    right[i] = String.Concat(root.val, "->", right[i]);
                }
            }
            else
            {
                right = new List<string>();
            }

            left.AddRange(right);

            return left;
        }
    }
}
