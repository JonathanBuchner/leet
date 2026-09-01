using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Problems.MinimumMovesToCleanTheClassroom;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumMovesToCleanTheClassroom_tests
    {
        [TestMethod]
        public void Basic2by2_tests()
        {
            var startingString = new string[] { "S.", "XL"};
            var energy = 2;
            var SUT = new Solution();

            var actual = SUT.MinMoves(startingString, energy);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Basic3by2_tests()
        {
            var startingString = new string[] { "L.S", "RXL" };
            var energy = 3;
            var SUT = new Solution();

            var actual = SUT.MinMoves(startingString, energy);

            Assert.AreEqual(-1, actual);
        }
    }
}
