using System;
using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using leet.LeetCode.Modules.LinkedList.IntersectOfTwoLinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class IntersectionOfTwoLinkedLists_tests
    {
        [TestMethod]
        public void Example1_Can_detect_intersection_node()
        {
            //Combined
            var combined = new MySinglyLinkedList(new ListNode(8));
            combined.AddAtTail(4);
            combined.AddAtTail(5);
            //List One
            var alist = new MySinglyLinkedList(new ListNode(4));
            alist.AddAtTail(1);
            alist.Tail.next = combined.Head;
            //List two
            var blist = new MySinglyLinkedList(new ListNode(5));
            blist.AddAtTail(6);
            blist.AddAtTail(1);
            blist.Tail.next = combined.Head;
            // Additional set up
            var expected = combined.Head;
            var sut = new Solution();

            var actual = sut.GetIntersectionNode(alist.Head, blist.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_detect_intersection_node_with_a_early_combine()
        {
            //Combined
            var combined = new MySinglyLinkedList(new ListNode(2));
            combined.AddAtTail(4);
            //List One
            var alist = new MySinglyLinkedList(new ListNode(3));
            alist.Tail.next = combined.Head;
            //List two
            var blist = new MySinglyLinkedList(new ListNode(1));
            blist.AddAtTail(9);
            blist.AddAtTail(1);
            blist.Tail.next = combined.Head;
            // Additional set up
            var expected = combined.Head;
            var sut = new Solution();

            var actual = sut.GetIntersectionNode(alist.Head, blist.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_return_null_if_lists_dont_combine()
        {
            var alist = new MySinglyLinkedList(new ListNode(3));
            //List two
            var blist = new MySinglyLinkedList(new ListNode(1));
            blist.AddAtTail(9);
            blist.AddAtTail(1);
            // Additional set up
            ListNode expected = null;
            var sut = new Solution();

            var actual = sut.GetIntersectionNode(alist.Head, blist.Head);

            Assert.AreEqual(expected, actual);
        }
    }
}
