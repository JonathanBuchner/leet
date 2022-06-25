using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.NonDecreasingArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class NonDecreasingArray_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                4,2,3
            };
            var expected = true;

            var actual = sut.CheckPossibility(input_nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                4,2,1
            };
            var expected = false;

            var actual = sut.CheckPossibility(input_nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase320()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                3,4,2,3
            };
            var expected = false;

            var actual = sut.CheckPossibility(input_nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
