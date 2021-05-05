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
        public void Can_answer_easy_question()
        {
            //List 1
            var node1 = new ListNode(1);
            var node2 = new ListNode(1, node1);
            var node3 = new ListNode(1, node2);

            //List 2
            var node4 = new ListNode(2);
            var node5 = new ListNode(2, node4);
            var node6 = new ListNode(2, node5);

            //Answer
            var node7 = new ListNode(3);
            var node8 = new ListNode(3, node7);
            var expected = new ListNode(3, node8);

            var actual = new Solution().AddTwoNumbers(node3, node6);

            while(expected !=null || actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        [TestMethod]
        public void Can_answer_example_question()
        {
            //List 1
            var node1 = new ListNode(3);
            var node2 = new ListNode(4, node1);
            var node3 = new ListNode(2, node2);

            //List 2
            var node4 = new ListNode(4);
            var node5 = new ListNode(6, node4);
            var node6 = new ListNode(5, node5);

            //Answer
            var node7 = new ListNode(8);
            var node8 = new ListNode(0, node7);
            var expected = new ListNode(7, node8);

            var actual = new Solution().AddTwoNumbers(node3, node6);

            while (expected != null || actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }
    }
}