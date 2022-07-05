using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.LongestConsecutiveSequence;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestConsecutiveSequence_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                100,4,200,1,3,2
            };
            var expected = 4;

            var actual = sut.LongestConsecutive(input_nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                0,3,7,2,5,8,4,6,0,1
            };
            var expected = 9;

            var actual = sut.LongestConsecutive(input_nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
