using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.HashTables.ContainsDuplicate;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class ContainsDuplicate_tests
    {
        [TestMethod]
        public void ContainsDuplicate_hasduplicate_returnstrue()
        {
            var sut = new Solution();
            var input = new int[] { 1, 2, 3, 1 };
            var expected = true;

            var actual = sut.ContainsDuplicate(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContainsDuplicate_noDuplicate_returnsFalse()
        {
            var sut = new Solution();
            var input = new int[] { 1, 2, 3, 1 };
            var expected = true;

            var actual = sut.ContainsDuplicate(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContainsDuplicate_hasMultipleDuplicates_returnsTrue()
        {
            var sut = new Solution();
            var input = new int[] { 1, 2, 3, 1 };
            var expected = true;

            var actual = sut.ContainsDuplicate(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
