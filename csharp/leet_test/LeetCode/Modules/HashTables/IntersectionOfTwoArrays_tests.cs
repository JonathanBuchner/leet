using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.HashTables.IntersectionOfTwoArrays;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class IntersectionOfTwoArrays_tests
    {
        [TestMethod]
        public void IntersectionOfTwoArrays_HasIntersection()
        {
            var sut = new Solution();
            var input1 = new int[] { 1, 2, 2, 1 };
            var input2 = new int[] { 2, 2};
            var expected = new int[] { 2 };

            var actual = sut.Intersection(input1, input2);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntersectionOfTwoArrays_MultipleIntersections()
        {
            var sut = new Solution();
            var input1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var input2 = new int[] { 0, 2, 4, 6, 8, 10, 12 };
            var expected = new int[] { 2, 4, 6, 8, 10 };

            var actual = sut.Intersection(input1, input2);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntersectionOfTwoArrays_HasNoIntersections()
        {
            var sut = new Solution();
            var input1 = new int[] { 1, 2, 2, 3 };
            var input2 = new int[] { 4, 5, 6 };
            var expected = new int[] { };

            var actual = sut.Intersection(input1, input2);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntersectionOfTwoArrays_EmptyList()
        {
            var sut = new Solution();
            var input1 = new int[] { 1, 2, 2, 3 };
            var input2 = new int[] {  };
            var expected = new int[] { };

            var actual = sut.Intersection(input1, input2);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntersectionOfTwoArrays_EmptyLists()
        {
            var sut = new Solution();
            var input1 = new int[] { };
            var input2 = new int[] { };
            var expected = new int[] { };

            var actual = sut.Intersection(input1, input2);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
