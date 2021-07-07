using leet.Cormen.Chapter2;
using leet.LeetCode.Models;
using leet_test.Helpers;
using leet.LeetCode.AddTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode
{
    [TestClass]
    public class Insertion_sort_tests
    {
        [TestMethod]
        public void Can_answer_easy_question()
        {
            var helper = new LinkedListHelper();
            var head1 = helper.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var head2 = helper.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var expected =helper.CreateSinglyLinkedList(new int[] { 3, 3, 3 });

            var actual = new Solution().AddTwoNumbers(head1, head2);

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
            var helper = new LinkedListHelper();
            var head1 = helper.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var head2 = helper.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 3, 3, 3 });

            var actual = new Solution().AddTwoNumbers(head1, head2);

            while (expected != null || actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        [TestMethod]
        public void Can_handle_different_lenght_lists_and_carry_one_for_list_node()
        {
            var helper = new LinkedListHelper();
            var head1 = helper.CreateSinglyLinkedList(new int[] { 9, 9, 9 });
            var head2 = helper.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 8, 9, 9, 0, 0, 0, 0, 1 });

            var actual = new Solution().AddTwoNumbers(head1, head2);

            while (expected != null || actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        public void Can_do_operations_on_long_list()
        {
            var helper = new LinkedListHelper();
            var arr1 = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            var arr2 = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            var arr3 = new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            var head1 = helper.CreateSinglyLinkedList(arr1);
            var head2 = helper.CreateSinglyLinkedList(arr2);
            var expected = helper.CreateSinglyLinkedList(arr3);

            var actual = new Solution().AddTwoNumbers(head1, head2);

            while (expected != null || actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }
    }
}