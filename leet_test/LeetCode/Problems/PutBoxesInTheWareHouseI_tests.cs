using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PutBoxesInTheWareHouseI;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PutBoxesInTheWareHouseI_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_boxes = new int[]
            {
                4,3,4,1
            };
            var input_warehouse = new int[]
            {
                5,3,3,4,1
            };
            var expected = 3;

            var actual = sut.MaxBoxesInWarehouse(input_boxes, input_warehouse);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_boxes = new int[]
            {
                1,2,2,3,4
            };
            var input_warehouse = new int[]
            {
                3,4,1,2
            };
            var expected = 3;

            var actual = sut.MaxBoxesInWarehouse(input_boxes, input_warehouse);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_boxes = new int[]
            {
                1,2,3
            };
            var input_warehouse = new int[]
            {
                1,2,3,4
            };
            var expected = 1;

            var actual = sut.MaxBoxesInWarehouse(input_boxes, input_warehouse);

            Assert.AreEqual(expected, actual);
        }
    }
}
