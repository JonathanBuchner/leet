using leet.LeetCode.Microsoft.LinkedLists.MergeKsortedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet_test.Helpers;
using leet.LeetCode.Models;

namespace leet_test.LeetCode.Microsoft.LinkedLists
{
    [TestClass]
    public class MergeKsortedLists
    {
        [TestMethod]
        public void MergeKLists_CanMergeLists()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input = new ListNode[]
            {
                helper.CreateSinglyLinkedList(new int[] { 1, 4, 5}),
                helper.CreateSinglyLinkedList(new int[] { 1, 3, 4}),
                helper.CreateSinglyLinkedList(new int[] { 2, 6 }),
            };
            var expected = helper.CreateSinglyLinkedList(new int[] { 1,1,2,3,4,4,5,6,});

            var actual = sut.MergeKLists(input);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void MergeKLists_CanMergeListsIfNoItemsInList()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input = new ListNode[0];
            ListNode expected = null;

            var actual = sut.MergeKLists(input);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void MergeKLists_CanMergeListsIfLinkedListsAreEmpty()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input = new ListNode[]
            {
                null,
            };
            ListNode expected = null;

            var actual = sut.MergeKLists(input);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
