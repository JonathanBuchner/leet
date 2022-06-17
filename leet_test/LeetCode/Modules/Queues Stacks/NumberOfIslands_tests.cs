using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Queue_Stack.NumberOfIslands;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Modules.Queues_Stacks
{
    [TestClass]
    public class NumberOfIslands_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new char[][]
            {
                new char[] {'1', '1', '1', '1', '1'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'},

            };
            var expected = 1;

            var actual = sut.NumIslands(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new char[][]
            {
                new char[] {'1', '1', '1', '1', '1'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '1', '0', '0'},
                new char[] {'0', '0', '0', '1', '1'},

            };
            var expected = 3;

            var actual = sut.NumIslands(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
