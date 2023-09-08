using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.DominoAndTrominoTiling;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class DominoAndTrominoTiling_tests
    {
        [TestMethod]
        public void NulTilings_Example1()
        {
            var sut = new Solution();
            var input = 3;
            var expected = 5;

            var actual = sut.NumTilings(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NulTilings_Example2()
        {
            var sut = new Solution();
            var input = 1;
            var expected = 1;

            var actual = sut.NumTilings(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NulTilings_SmallInput()
        {
            var sut = new Solution();
            var input = 2;
            var expected = 2;

            var actual = sut.NumTilings(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
