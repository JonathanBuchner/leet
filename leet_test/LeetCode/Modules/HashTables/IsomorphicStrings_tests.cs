using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.IsomorphicStrings;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class IsomorphicStrings_tests
    {
        [TestMethod]
        [DataRow("egg", "add", true)]
        [DataRow("foo", "var", false)]
        [DataRow("paper", "title", true)]

        public void IsIsmorphic(string input1, string input2, bool expected)
        {
            var sut = new Solution();

            var actual = sut.IsIsomorphic(input1, input2);

            Assert.AreEqual(expected, actual);
        }
    }
}
