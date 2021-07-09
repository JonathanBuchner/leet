using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.ReplaceElementsWithGreatestElementOnRightSide;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class ReplaceElementsWithGreatestElementOnRightSide_tests
    {
        [TestMethod]
        public void Example1_Can_Corrrectly_Replace_Elements()
        {
            var input = new int[] { 17, 18, 5, 4, 6, 1 };
            var expected = new int[] { 18, 6, 6, 6, 1, -1 };
            var sut = new Solution();

            var actual = sut.ReplaceElements(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_corrrectly_handel_single_entry()
        {
            var input = new int[] { 400 };
            var expected = new int[] { -1 };
            var sut = new Solution();

            var actual = sut.ReplaceElements(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
