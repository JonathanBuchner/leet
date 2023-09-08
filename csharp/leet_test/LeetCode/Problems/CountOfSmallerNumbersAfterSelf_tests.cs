using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.CountOfSmallerNumbersAfterSelf;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class CountOfSmallerNumbersAfterSelf_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                5,2,6,1
            };
            var expected = new int[]
            {
                2,1,1,0
            };

            var actual = sut.CountSmaller(nums);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                -1
            };
            var expected = new int[]
            {
                0
            };

            var actual = sut.CountSmaller(nums);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                -1,-1
            };
            var expected = new int[]
            {
                0, 0
            };

            var actual = sut.CountSmaller(nums);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
