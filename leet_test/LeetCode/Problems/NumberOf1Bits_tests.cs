using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.NumberOf1Bits;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class NumberOf1Bits_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            uint input = 11;
            var expected = 3;

            var actual = sut.HammingWeight(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            uint input = 128;
            var expected = 1;

            var actual = sut.HammingWeight(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            uint input = 4294967293;
            var expected = 31;

            var actual = sut.HammingWeight(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
