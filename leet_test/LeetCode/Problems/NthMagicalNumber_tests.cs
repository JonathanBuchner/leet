using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.NthMagicalNumber;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class NthMagicalNumber_tests
    {
        [TestMethod]
        [DataRow(1, 2, 3, 2)]
        [DataRow(4, 2, 3, 6)]
        [DataRow(5, 2, 4, 10)]
        [DataRow(3, 6, 4, 8)]
        public void NthMagicalNumber_Examples(int n, int a, int b, int expected)
        {
            var sut = new Solution();

            var actual = sut.NthMagicalNumber(n, a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(1000000000, 40000, 40000, 999720007)]
        [DataRow(307673195, 37340, 36427, 239828629)]
        public void NthMagicalNumber_Tests(int n, int a, int b, int expected)
        {
            var sut = new Solution();

            var actual = sut.NthMagicalNumber(n, a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
