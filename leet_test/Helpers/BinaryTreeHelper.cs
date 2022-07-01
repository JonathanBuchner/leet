using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.Helpers
{
    public static class BinaryTreeHelper
    {
        public static TreeNode MakeTree(int?[] arr)
        {
            var queue = new Queue<TreeNode>();
            var i = 0;

            if(arr == null || arr.Length == 0 || arr[i] == null)
            {
                return null;
            }

            var root = new TreeNode((int)arr[i]);
            i++;

            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                var curr = queue.Dequeue();

                if (i >= arr.Length)
                {
                    curr.left = null;
                    curr.right = null;
                }
                else if(i == arr.Length - 1)
                {
                    curr.left = GetNode(arr[i]);
                    curr.right = null;
                    i++;
                } 
                else
                {
                    curr.left = GetNode(arr[i]);
                    curr.right = GetNode(arr[i+1]);
                    i += 2;
                    
                    if(curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
            }

            return root;
        }

        private static TreeNode GetNode(int? val)
        {
            return val == null ? null : new TreeNode((int)val);
        }
    }
}
