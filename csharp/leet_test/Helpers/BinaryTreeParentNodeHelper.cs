using leet.LeetCode.Models.NodeParent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_test.Helpers
{
    public static class BinaryTreeParentNodeHelper
    {
        public static Node MakeTree(int?[] arr, int start = 0)
        {
            var queue = new Queue<List<Node>>();
            var i = 0;

            if (arr == null || arr.Length == 0 || arr[i] == null)
            {
                return null;
            }
            Node result;
            var root = result = new Node((int)arr[i]);
            i++;

            queue.Enqueue(new List<Node>() { root, null });

            while (queue.Count != 0)
            {
                var curr = queue.Dequeue();
                curr[0].parent = curr[1];

                if(curr[0].val == start)
                {
                    result = curr[0];
                }

                if (i >= arr.Length)
                {
                    curr[0].left = null;
                    curr[0].right = null;
                }
                else if (i == arr.Length - 1)
                {
                    curr[0].left = GetNode(arr[i]);
                    curr[0].right = null;
                    i++;
                }
                else
                {
                    curr[0].left = GetNode(arr[i]);
                    curr[0].right = GetNode(arr[i + 1]);
                    i += 2;

                    if (curr[0].left != null)
                    {
                        queue.Enqueue(new List<Node>() { curr[0].left, curr[0] });
                    }

                    if (curr[0].right != null)
                    {
                        queue.Enqueue(new List<Node>() { curr[0].right, curr[0] });
                    }
                }
            }

            return result;
        }

        private static Node GetNode(int? val)
        {
            return val == null ? null : new Node((int)val);
        }
    }
}

