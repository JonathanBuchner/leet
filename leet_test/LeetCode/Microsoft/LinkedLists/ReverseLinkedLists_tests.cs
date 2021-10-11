using leet.LeetCode.Microsoft.LinkedLists.ReverseLinkedLists;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Microsoft.LinkedLists
{
    [TestClass]
    public class ReverseLinkedLists_tests
    {
        [TestMethod]
        public void Example1_Can_reverse_list()
        {
            var helper = new LinkedListHelper();
            var list = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5 });
            var expected = helper.CreateSinglyLinkedList(new int[] {5, 4, 3, 2, 1 });
            var sut = new Solution();

            var actual = sut.ReverseList(list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_reverse_short_list()
        {
            var helper = new LinkedListHelper();
            var list = helper.CreateSinglyLinkedList(new int[] { 1, 2 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 2, 1 });
            var sut = new Solution();

            var actual = sut.ReverseList(list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }


        [TestMethod]
        public void Example3_Can_handle_list_of_one()
        {
            var helper = new LinkedListHelper();
            var list = helper.CreateSinglyLinkedList(new int[] { 1 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1 });
            var sut = new Solution();

            var actual = sut.ReverseList(list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
