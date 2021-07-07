using leet.LeetCode.Modules.LinkedList.RemoveNthNodeFromEndOfList;
using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class RemoveNthNodeFromEndOfList
    {
        [TestMethod]
        public void Example1_Can_remove_item_from_list()
        {
            var list = new MySinglyLinkedList(new ListNode(0));
            list.AddAtTail(1);
            list.AddAtTail(2);
            list.AddAtTail(3);
            list.AddAtTail(4);
            list.AddAtTail(5);
            var expected = list.GetNode(5);
            var sut = new Solution();

            var head = sut.RemoveNthFromEnd(list.Head, 2);
            var actual = list.GetNode(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_remove_if_only_one_node_in_list()
        {
            var list = new MySinglyLinkedList(new ListNode(0));
            ListNode expected = null;
            var sut = new Solution();

            var actual = sut.RemoveNthFromEnd(list.Head, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_remove_second_item_from_list_of_two()
        {
            var list = new MySinglyLinkedList(new ListNode(0));
            list.AddAtTail(1);
            var expected = list.Head;
            var sut = new Solution();

            var actual = sut.RemoveNthFromEnd(list.Head, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example4_Can_remove_first_item_from_list_of_two()
        {
            var list = new MySinglyLinkedList(new ListNode(0));
            list.AddAtTail(1);
            var expected = list.GetNode(1);
            var sut = new Solution();

            var actual = sut.RemoveNthFromEnd(list.Head, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
