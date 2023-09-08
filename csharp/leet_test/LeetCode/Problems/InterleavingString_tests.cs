using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.InterleavingString;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class InterleavingString_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_s1 = "aabcc";
            var input_s2 = "dbbca";
            var input_s3 = "aadbbcbcac";
            var expected = true;

            var actual = sut.IsInterleave(input_s1, input_s2, input_s3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_s1 = "aabcc";
            var input_s2 = "dbbca";
            var input_s3 = "aadbbbaccc";
            var expected = false;

            var actual = sut.IsInterleave(input_s1, input_s2, input_s3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_s1 = "";
            var input_s2 = "";
            var input_s3 = "";
            var expected = true;

            var actual = sut.IsInterleave(input_s1, input_s2, input_s3);

            Assert.AreEqual(expected, actual);
        }
    }
}
