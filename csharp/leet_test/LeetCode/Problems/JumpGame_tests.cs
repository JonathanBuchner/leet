using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.JumpGame;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class JumpGame_tests
    {
        [TestMethod]
        public void Example0()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                1,-2,4,-7,3
            };
            var steps = 2;
            var expected = 8;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                1,-1,-2,4,-7,3
            };
            var steps = 2;
            var expected = 7;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                10,-5,-2,4,0,3
            };
            var steps = 3;
            var expected = 17;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                1,-5,-20,4,-1,3,-6,-3
            };
            var steps = 2;
            var expected = 0;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase27()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                100, -1, -100, -1, 100
            };
            var steps = 2;
            var expected = 198;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase28()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                100, -100, -300, -300, -300, -100, 100
            };
            var steps = 4;
            var expected = 0;

            var actual = sut.MaxResult(nums, steps);

            Assert.AreEqual(expected, actual);
        }
    }
}
