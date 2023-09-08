using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PartitionIntoMinimumNumverOfDeciBinaryNumbers;

namespace leet_test.LeetCode.Problems
{

    [TestClass]
    public class PartitionIntoMinimumNumverOfDeciBinaryNumbers_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_num = "32";
            var expected = 3;

            var actual = sut.MinPartitions(input_num);

            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_num = "82734";
            var expected = 8;

            var actual = sut.MinPartitions(input_num);

            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_num = "27346209830709182346";
            var expected = 9;

            var actual = sut.MinPartitions(input_num);

            Assert.AreEqual(expected, actual);
        }
    }
}
