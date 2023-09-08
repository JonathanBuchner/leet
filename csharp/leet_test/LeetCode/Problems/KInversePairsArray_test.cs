using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.KInversePairsArray;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class KInversePairsArray_test
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var number = 3;
            var inversePairs = 0;
            var expected = 1;

            var actual = sut.KInversePairs(number, inversePairs);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var number = 3;
            var inversePairs = 1;
            var expected = 2;

            var actual = sut.KInversePairs(number, inversePairs);

            Assert.AreEqual(expected, actual);
        }
    }
}
