using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.LinkedList.OddEvenLinkedList;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class OddEvenLinkedList_tests
    {
        [TestMethod]
        public void OddEvenList_EvenList_ReturnsListOddEven()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_list = helper.CreateSinglyLinkedList( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 3, 5, 7, 2, 4, 6, 8 });

            var actual = sut.OddEvenList(input_list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void OddEvenList_OddList_ReturnsListOddEven()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_list = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 3, 5, 7, 2, 4, 6  });

            var actual = sut.OddEvenList(input_list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void OddEvenList_Empty_ReturnsEmpty()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_list = helper.CreateSinglyLinkedList(new int[] { });
            var expected = helper.CreateSinglyLinkedList(new int[] { });

            var actual = sut.OddEvenList(input_list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void OddEvenList_OneItemList_ReturnsListOddEven()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_list = helper.CreateSinglyLinkedList(new int[] { 1 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1 });

            var actual = sut.OddEvenList(input_list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void OddEvenList_TwoItemList_ReturnsListOddEven()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_list = helper.CreateSinglyLinkedList(new int[] { 1, 2 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2 });

            var actual = sut.OddEvenList(input_list);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
