using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MatchstickToSquares;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MathstickToSquares_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var matchsticks = new int[]
            {
                1,1,2,2,2
            };
            var expected = true;

            var actual = sut.Makesquare(matchsticks);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var matchsticks = new int[]
            {
                3,3,3,3,4
            };
            var expected = false;

            var actual = sut.Makesquare(matchsticks);

            Assert.AreEqual(expected, actual);
        }
    }
}
