using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.LinkedList.PalindromeLinkedList;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class PalindromeLinkedLists_tests
    {
        [TestMethod]
        public void Solution_CanHandleEmptyList()
        {
            var nums = new int[0];
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleOneList()
        {
            var nums = new int[] { 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleTwoList()
        {
            var nums = new int[] { 1, 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleThreeList()
        {
            var nums = new int[] { 1, 1, 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleTrue()
        {
            var nums = new int[] { 1, 2, 2, 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleFalse()
        {
            var nums = new int[] { 1, 2, 1, 2, 3};
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = false;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleComplexEvenTrue()
        {
            var nums = new int[] { 1, 2, 5, 134, -56, Int32.MaxValue, 0, Int32.MinValue, Int32.MinValue, 0, Int32.MaxValue, -56, 134, 5, 2, 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution_CanHandleComplexOddTrue()
        {
            var nums = new int[] { 1, 2, 5, 134, -56, Int32.MaxValue, 0, Int32.MinValue, 1 , Int32.MinValue, 0, Int32.MaxValue, -56, 134, 5, 2, 1 };
            var list = new LinkedListHelper().CreateSinglyLinkedList(nums);
            var sut = new Solution();
            var expected = true;

            var actual = sut.IsPalindrome(list);

            Assert.AreEqual(expected, actual);
        }
    }
}
