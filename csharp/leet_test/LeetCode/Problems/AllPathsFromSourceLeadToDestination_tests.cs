using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.AllPathsFromSourceLeadToDestination;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class AllPathsFromSourceLeadToDestination_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nodes = 3;
            var edges = new int[][]
            {
                //[[0,1],[0,2]]
                new int[] { 0, 1},
                new int[] { 0, 2},
            };
            var source = 0;
            var destination = 2;
            var expected = false;

            var actual = sut.LeadsToDestination(nodes, edges, source, destination);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nodes = 4;
            var edges = new int[][]
            {
                //[0,1],[0,3],[1,2],[2,1]
                new int[] { 0, 1},
                new int[] { 0, 3},
                new int[] { 1, 2},
                new int[] { 2, 1},
            };
            var source = 0;
            var destination = 3;
            var expected = false;

            var actual = sut.LeadsToDestination(nodes, edges, source, destination);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nodes = 4;
            var edges = new int[][]
            {
                //[[0,1],[0,2],[1,3],[2,3]]
                new int[] { 0, 1},
                new int[] { 0, 2},
                new int[] { 1, 3},
                new int[] { 2, 3},
            };
            var source = 0;
            var destination = 3;
            var expected = true;

            var actual = sut.LeadsToDestination(nodes, edges, source, destination);

            Assert.AreEqual(expected, actual);
        }


    }
}
