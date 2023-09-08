using leet.LeetCode.Microsoft.LinkedLists.MergeTwoSortedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet_test.Helpers;

namespace leet_test.LeetCode.Microsoft.LinkedLists
{
    [TestClass]
    public class MergeTwoSortedLists_tests
    {
        [TestMethod]
        public void MergeTwoLists_CanMergeLists()
        {
            var sut = new Solution();
            var helper_ll= new LinkedListHelper();
            var input_l1 = helper_ll.CreateSinglyLinkedList(new int[] { 1, 2, 4 });
            var input_l2 = helper_ll.CreateSinglyLinkedList(new int[] { 1, 3, 4 });
            var expected = helper_ll.CreateSinglyLinkedList(new int[] { 1, 1, 2, 3, 4, 4 });

            var actual = sut.MergeTwoLists(input_l1, input_l2);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
        [TestMethod]
        public void MergeTwoLists_CanMergeEmptyLists()
        {
            var sut = new Solution();
            var helper_ll = new LinkedListHelper();
            var input_l1 = helper_ll.CreateSinglyLinkedList(new int[] {  });
            var input_l2 = helper_ll.CreateSinglyLinkedList(new int[] {  });
            var expected = helper_ll.CreateSinglyLinkedList(new int[] {  });

            var actual = sut.MergeTwoLists(input_l1, input_l2);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
        [TestMethod]
        public void MergeTwoLists_CanMergeIfAListIsEmpty()
        {
            var sut = new Solution();
            var helper_ll = new LinkedListHelper();
            var input_l1 = helper_ll.CreateSinglyLinkedList(new int[] { });
            var input_l2 = helper_ll.CreateSinglyLinkedList(new int[] { 1 });
            var expected = helper_ll.CreateSinglyLinkedList(new int[] { 1 });

            var actual = sut.MergeTwoLists(input_l1, input_l2);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
