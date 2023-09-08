using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.LongestIncreasingSubsequence;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestIncreasingSubsequence_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                10,9,2,5,3,7,101,18
            };
            var expected = 4;

            var actual = sut.LengthOfLIS(nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nums = new int[]
            {
               0,1,0,3,2,3
            };
            var expected = 4;

            var actual = sut.LengthOfLIS(nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nums = new int[]
            {
               7,7,7,7,7,7,7
            };
            var expected = 1;

            var actual = sut.LengthOfLIS(nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyCase()
        {
            var sut = new Solution();
            var nums = new int[]
            {
               10, 9 , 8, 7 , 6 , 6 , 7, 8, 10, 8, 6, 4, 1 , 2, 3, 4, 5, 6, 7, 8, 9 
            };
            var expected = 9;

            var actual = sut.LengthOfLIS(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
