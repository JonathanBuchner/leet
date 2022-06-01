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
    }
}
