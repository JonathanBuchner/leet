using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumMovestoEqualArrayElementsII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumMovestoEqualArrayElementsII_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                1,2,3
            };
            var expected = 2;
                
            var actual = sut.MinMoves2(input_nums);

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                1,10,2,9
            };
            var expected = 16;

            var actual = sut.MinMoves2(input_nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase15()
        {
            var sut = new Solution();
            // 0, 0, 1, 6, 8
            var input_nums = new int[]
            {
                1, 0, 0, 8, 6
            };
            var expected = 14;

            var actual = sut.MinMoves2(input_nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
