using leet.LeetCode.Problems.FindFirstAndLestPositionofElementsInSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class FindFirstAndLestPositionofElementsInSortedArray_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                5,7,7,8,8,10
            };
            var target = 8;
            var expected = new int[]
            {
                3,4
            };

            var actual = sut.SearchRange(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                5,7,7,8,8,10
            };
            var target = 6;
            var expected = new int[]
            {
                -1, -1
            };

            var actual = sut.SearchRange(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nums = new int[]
            {
                
            };
            var target = 0;
            var expected = new int[]
            {
                -1, -1
            };

            var actual = sut.SearchRange(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
