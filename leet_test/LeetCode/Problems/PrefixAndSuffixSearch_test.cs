using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.PrefixAndSuffixSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PrefixAndSuffixSearch_test
    {
        [TestMethod]
        public void Exampl1()
        {
            var input = new string[]
            {
                "Apple",
            };
            var sut = new WordFilter(input);
            var expected = 0;

            var actual = sut.F("a", "e");

            Assert.AreEqual(expected, actual);
        }
    }
}
