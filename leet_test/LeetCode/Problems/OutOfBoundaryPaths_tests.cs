using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.OutOfBoundaryPaths;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class OutOfBoundaryPaths_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var m = 2;
            var n = 2;
            var maxMoves = 2;
            var startRow = 0;
            var startColumn = 0;
            var expected = 6;

            var actual = sut.FindPaths(m, n, maxMoves, startRow, startColumn);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var m = 1;
            var n = 3;
            var maxMoves = 3;
            var startRow = 0;
            var startColumn = 1;
            var expected = 12;

            var actual = sut.FindPaths(m, n, maxMoves, startRow, startColumn);

            Assert.AreEqual(expected, actual);
        }
    }
}
