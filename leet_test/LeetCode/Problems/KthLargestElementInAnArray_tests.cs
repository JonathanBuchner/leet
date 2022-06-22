using leet.LeetCode.Problems.KthLargestElementInAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class KthLargestElementInAnArray_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                   3,2,1,5,6,4
            };
            var input_k = 2;
            var expected = 5;

            var actual = sut.FindKthLargest(input_nums, input_k);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_nums = new int[]
            {
                 3,2,3,1,2,4,5,5,6
            };
            var input_k = 4;
            var expected = 4;

            var actual = sut.FindKthLargest(input_nums, input_k);

            Assert.AreEqual(expected, actual);
        }
    }
}
