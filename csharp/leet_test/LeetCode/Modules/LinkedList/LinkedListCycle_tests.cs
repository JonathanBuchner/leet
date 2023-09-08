using System;
using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using leet.LeetCode.Modules.LinkedList.LinkedListCycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class LinkedListCycle_tests
    {
        [TestMethod]
        public void Example1_Can_tell_cycle()
        {
            var list = new MySinglyLinkedList(new ListNode(3));
            list.AddAtTail(2);
            list.AddAtTail(0);
            list.AddAtTail(4);
            list.Tail.next = list.GetNode(1);
            var expected = true;
            var sut = new Solution();

            var actual = sut.HasCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_tell_cycle_when_two_nodes()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            list.AddAtTail(2);
            list.Tail.next = list.Head;
            var expected = true;
            var sut = new Solution();

            var actual = sut.HasCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_tell_NO_cycle_when_one_node()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            var expected = false;
            var sut = new Solution();

            var actual = sut.HasCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example4_Can_tell_NO_cycle_when_may_node()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            var expected = false;
            var sut = new Solution();

            var actual = sut.HasCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example1_Can_detect_cycle()
        {
            var list = new MySinglyLinkedList(new ListNode(3));
            list.AddAtTail(2);
            list.AddAtTail(0);
            list.AddAtTail(4);
            list.Tail.next = list.GetNode(1);
            var expected = list.GetNode(1);
            var sut = new Solution();

            var actual = sut.DetectCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_detect_cycle_when_two_nodes()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            list.AddAtTail(2);
            list.Tail.next = list.Head;
            var expected = list.Head;
            var sut = new Solution();

            var actual = sut.DetectCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_detect_NO_cycle_when_one_node()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            ListNode expected = null;
            var sut = new Solution();

            var actual = sut.DetectCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_detect_NO_cycle_when_may_node()
        {
            var list = new MySinglyLinkedList(new ListNode(1));
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            list.AddAtTail(2);
            ListNode expected = null;
            var sut = new Solution();

            var actual = sut.DetectCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Can_detect_10_list_with_even_cycle()
        {
            var list = new MySinglyLinkedList(new ListNode(-1));
            list.AddAtTail(-7);
            list.AddAtTail(7);
            list.AddAtTail(-4);
            list.AddAtTail(19);
            list.AddAtTail(6);
            list.AddAtTail(-9);
            list.AddAtTail(-5);
            list.AddAtTail(-2);
            // list.AddAtTail(-5);
            list.Tail.next = list.GetNode(6);
            ListNode expected = list.GetNode(6);
            var sut = new Solution();

            var actual = sut.DetectCycle(list.Head);

            Assert.AreEqual(expected, actual);
        }
    }
}
