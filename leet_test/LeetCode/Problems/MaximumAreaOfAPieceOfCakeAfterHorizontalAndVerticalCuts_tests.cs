using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_h = 5;
            var input_w = 4;
            var input_horizontalCuts = new int[]
            {
                1,2,4
            };
            var input_verticalCuts = new int[]
            {
                1,3
            };
            var expected = 4;

            var actual = sut.MaxArea(input_h, input_w, input_horizontalCuts, input_verticalCuts);
        
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_h = 5;
            var input_w = 4;
            var input_horizontalCuts = new int[]
            {
                3,1
            };
            var input_verticalCuts = new int[]
            {
                1
            };
            var expected = 6;

            var actual = sut.MaxArea(input_h, input_w, input_horizontalCuts, input_verticalCuts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_h = 5;
            var input_w = 4;
            var input_horizontalCuts = new int[]
            {
                3
            };
            var input_verticalCuts = new int[]
            {
                3
            };
            var expected = 9;

            var actual = sut.MaxArea(input_h, input_w, input_horizontalCuts, input_verticalCuts);

            Assert.AreEqual(expected, actual);
        }
    }
}
