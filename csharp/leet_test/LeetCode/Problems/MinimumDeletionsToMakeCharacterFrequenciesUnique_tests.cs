using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumDeletionsToMakeCharacterFrequenciesUnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumDeletionsToMakeCharacterFrequenciesUnique_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_string = "aab";
            var expected = 0;

            var actual = sut.MinDeletions(input_string);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_string = "aaabbbcc";
            var expected = 2;

            var actual = sut.MinDeletions(input_string);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_string = "ceabaacb";
            var expected = 2;

            var actual = sut.MinDeletions(input_string);

            Assert.AreEqual(expected, actual);
        }
    }
}
