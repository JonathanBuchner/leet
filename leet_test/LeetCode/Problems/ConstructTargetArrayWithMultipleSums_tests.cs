using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.ConstructTargetArrayWithMultipleSums;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ConstructTargetArrayWithMultipleSums_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_target = new int[]
            {
                9,3,5
            };
            var expected = true;

            var actual = sut.IsPossible(input_target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_target = new int[]
            {
                1,1,1,2
            };
            var expected = false;

            var actual = sut.IsPossible(input_target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_target = new int[]
            {
                8,5
            };
            var expected = true;

            var actual = sut.IsPossible(input_target);

            Assert.AreEqual(expected, actual);
        }
    }
}
