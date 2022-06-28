using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.ExcelSheetColumnNumber;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ExcelSheetColumnNumber_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_title = "A";
            var expected = 1;

            var actual = sut.TitleToNumber(input_title);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_title = "A";
            var expected = 1;

            var actual = sut.TitleToNumber(input_title);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_title = "ZY";
            var expected = 701;

            var actual = sut.TitleToNumber(input_title);

            Assert.AreEqual(expected, actual);
        }
    }
}
