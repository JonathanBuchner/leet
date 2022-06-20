using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Queue_Stack.OpenTheLock;

namespace leet_test.LeetCode.Modules.Queues_Stacks
{
    [TestClass]
    public class OpenTheLock_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_deadEnds = new string[]
            {
                "0201","0101","0102","1212","2002"
            };
            var input_target = "0202";
            var expected = 6;

            var actual = sut.OpenLock(input_deadEnds, input_target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_deadEnds = new string[]
            {
               "8887","8889","8878","8898","8788","8988","7888","9888"
            };
            var input_target = "8888";
            var expexted = -1;

            var actual = sut.OpenLock(input_deadEnds, input_target);

            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_deadEnds = new string[]
            {
                "8888"
            };
            var input_target = "0009";
            var expected = 1;

            var actual = sut.OpenLock(input_deadEnds, input_target);

            Assert.AreEqual(expected, actual);
        }
    }
}
