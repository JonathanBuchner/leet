using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Queue_Stack.PerfectSquares;

namespace leet_test.LeetCode.Modules.Queues_Stacks
{
    [TestClass]
    public class PerfectSquares_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = 12;
            var expected = 3;

            var actual = sut.NumSquares(input);

            Assert.AreEqual(expected, actual);
        }
  
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = 13;
            var expected = 2;

            var actual = sut.NumSquares(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
