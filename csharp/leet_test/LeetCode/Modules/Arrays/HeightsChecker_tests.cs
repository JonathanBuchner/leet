using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Arrays.HeightChecker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class HeightsChecker_tests
    {
        [TestMethod]
        public void Example1_Can_return_indecies_that_are_out_of_line()
        {
            var input = new int[] { 1, 1, 4, 2, 1, 3 };
            var expected = 3;
            var sut = new Solution();

            var actual = sut.HeightChecker(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2_Can_detect_if_every_number_is_in_incorrect_position()
        {
            var input = new int[] { 5, 1, 2, 3, 4 };
            var expected = 5;
            var sut = new Solution();

            var actual = sut.HeightChecker(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_dectect_if_every_number_is_in_the_correct_position()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var expected = 0;
            var sut = new Solution();

            var actual = sut.HeightChecker(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
