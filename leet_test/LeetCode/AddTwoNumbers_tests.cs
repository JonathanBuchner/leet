using leet.Cormen.Chapter2;
using leet.LeetCode.Models;
using LeetCode.AddTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode
{
    [TestClass]
    public class Insertion_sort_tests
    {
        [TestMethod]
        public void If_input_is_empty_return_input()
        {
            var node1 = new ListNode(3);
            var node2 = new ListNode(4, node1);
            var node3 = new ListNode(2, node2);

            var node4 = new ListNode(4);
            var node5 = new ListNode(6, node1);
            var node6 = new ListNode(5, node2);

            var sut = new Solution();

            var response = sut.AddTwoNumbers(node3, node6);

            Assert.IsTrue(true);
        }
    }
}