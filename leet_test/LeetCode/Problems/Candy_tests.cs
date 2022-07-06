using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.Candy;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Candy_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_rating = new int[]
            {
                1,0,2
            };
            var expected = 5;

            var actual = sut.Candy(input_rating);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_rating = new int[]
            {
                1,2,2
            };
            var expected = 4;

            var actual = sut.Candy(input_rating);

            Assert.AreEqual(expected, actual);
        }
    }
}
