using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Models;

namespace leet.LeetCode.Microsoft.LinkedLists.CopyListwithRandomPointer
{
    /*
     * Copy List with Random Pointer
     * 
     * A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or null.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/32/linked-list/168/
     */
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            var curr = head;
            Node headC = null;
            Node currC = null;
            var map = new Dictionary<Node, Node>();

            while(curr != null)
            {
                var node = new Node(curr.val);
                map.Add(curr, node);

                if (headC == null)
                {
                    currC = headC = node;
                }
                else
                {
                    currC = currC.next = node;
                }

                curr = curr.next;
            }

            curr = head;
            currC = headC;

            while(curr != null || currC != null)
            {
                currC.random = curr.random != null ? map[curr.random] : null;

                curr = curr.next;
                currC = currC.next;
            }

            return headC;
        }
    }
}
