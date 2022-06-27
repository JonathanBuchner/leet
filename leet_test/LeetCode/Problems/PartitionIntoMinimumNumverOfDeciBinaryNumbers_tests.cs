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
    }
}
