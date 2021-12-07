using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Problems.IntegerToRoman;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class IntegerToRoman_tests
    {
        [TestMethod]
        public void IntToRoman_Example1()
        {
            var sut = new Solution();
            var input = 3;
            var expected = "III";

            var actual = sut.IntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_Example2()
        {
            var sut = new Solution();
            var input = 4;
            var expected = "IV";

            var actual = sut.IntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_Example3()
        {
            var sut = new Solution();
            var input = 9;
            var expected = "IX";

            var actual = sut.IntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_Example4()
        {
            var sut = new Solution();
            var input = 58;
            var expected = "LVIII";

            var actual = sut.IntToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_Example5()
        {
            var sut = new Solution();
            var input = 1994;
            var expected = "MCMXCIV";

            var actual = sut.IntToRoman(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
