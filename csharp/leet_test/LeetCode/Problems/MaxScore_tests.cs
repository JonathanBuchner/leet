using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MaxScore;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MaxScore_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_expectedCards = new int[]
            {
                1,2,3,4,5,6,1
            };
            var input_cardsTake = 3;
            var expected = 12;

            var actual = sut.MaxScore(input_expectedCards, input_cardsTake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_expectedCards = new int[]
            {
                2,2,2
            };
            var input_cardsTake = 2;
            var expected = 4;

            var actual = sut.MaxScore(input_expectedCards, input_cardsTake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_expectedCards = new int[]
            {
                9,7,7,9,7,7,9
            };
            var input_cardsTake = 7;
            var expected = 55;

            var actual = sut.MaxScore(input_expectedCards, input_cardsTake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase8()
        {
            var sut = new Solution();
            var input_expectedCards = new int[]
            {
                100, 40, 17, 9, 73, 75
            };
            var input_cardsTake = 3;
            var expected = 248;

            var actual = sut.MaxScore(input_expectedCards, input_cardsTake);

            Assert.AreEqual(expected, actual);
        }
    }
}
