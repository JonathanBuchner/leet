using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.HashTables.HappyNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class HappyNumber_tests
    {
        [TestMethod]
        public void IsHappy_loops()
        {
            var sut = new Solution();
            var input = 19;
            var expected = true;

            var actual = sut.IsHappy(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsHappy_noLoop()
        {
            var sut = new Solution();
            var input = 2;
            var expected = false;

            var actual = sut.IsHappy(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
