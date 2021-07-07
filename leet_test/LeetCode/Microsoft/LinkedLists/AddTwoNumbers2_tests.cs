using leet.LeetCode.Microsoft.LinkedLists.AddTwoNumbers2;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Microsoft.LinkedLists
{
    [TestClass]
    public class AddTwoNumbers2_tests
    {
        [TestMethod]
        public void Example1_Can_add_two_numbers_of_different_length()
        {
            var helper = new LinkedListHelper();
            var input1 = helper.CreateSinglyLinkedList(new int[] { 7, 2, 4, 3 });
            var input2 = helper.CreateSinglyLinkedList(new int[] { 5, 6, 4 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 7, 8, 0, 7 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input1, input2);

            AssertLinkedList.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_add_two_numbers_of_same_length()
        {
            var helper = new LinkedListHelper();
            var input1 = helper.CreateSinglyLinkedList(new int[] { 2, 4, 3 });
            var input2 = helper.CreateSinglyLinkedList(new int[] { 5, 6, 4 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 8, 0, 7 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input1, input2);

            AssertLinkedList.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_add_two_zeroes()
        {
            var helper = new LinkedListHelper();
            var input1 = helper.CreateSinglyLinkedList(new int[] { 0 });
            var input2 = helper.CreateSinglyLinkedList(new int[] { 0 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 0});
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input1, input2);

            AssertLinkedList.AreEqual(expected, actual);
        }
    }
}
