using leet.LeetCode.Modules.Queue_Stack.WallsAndGates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Modules.Queues_Stacks
{
    [TestClass]
    public class WallsAndGates_tests
    {
        [TestMethod]
        public void TestCase8()
        {
            var sut = new Solution();
            var input = new int[][]
            {
                new int[] { 2147483647,0,2147483647,2147483647,0,2147483647,-1,2147483647}
            };
            var expected = new int[][]
            {
                new int[] {1,0,1,1,0,1,-1,2147483647}
            };

            sut.WallsAndGates(input);

            Assert.AreEqual(expected, input);
        }
    }
}
