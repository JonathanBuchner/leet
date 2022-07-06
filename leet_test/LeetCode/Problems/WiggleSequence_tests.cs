using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.WiggleSequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class WiggleSequence_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_seq = new int[]
            {
                1,7,4,9,2,5
            };
            var expected = 6;

            var acutal = sut.WiggleMaxLength(input_seq);
        
            Assert.AreEqual(expected, acutal);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_seq = new int[]
            {
                1,17,5,10,13,15,10,5,16,8
            };
            var expected = 7;

            var acutal = sut.WiggleMaxLength(input_seq);

            Assert.AreEqual(expected, acutal);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_seq = new int[]
            {
               1,2,3,4,5,6,7,8,9
            };
            var expected = 2;

            var acutal = sut.WiggleMaxLength(input_seq);

            Assert.AreEqual(expected, acutal);
        }
    }
}
