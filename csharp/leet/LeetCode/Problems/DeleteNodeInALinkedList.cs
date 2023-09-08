using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DeleteNodeInALinkedList
{
    /*
     * Delete Node in a Linked List
     * 
     * Write a function to delete a node in a singly-linked list. You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly. It is guaranteed that the node to be deleted is not a tail node in the list.
     * 
     * https://leetcode.com/problems/delete-node-in-a-linked-list/
     */
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            while (node.next.next != null)
            {
                node.val = node.next.val;
                node = node.next;
            }

            node.val = node.next.val;
            node.next = null;
        }
    }
}
