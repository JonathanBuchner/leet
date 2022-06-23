using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.CourseScheduleIII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    internal class CourseScheduleIII_test
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_courses = new int[][]
            {
                new int[] { 100,200 },
                new int[] { 200,1300 },
                new int[] { 1000,1250 },
                new int[] { 2000,3200 },
            };
            var expected = 3;

            var actual = sut.ScheduleCourse(input_courses);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_courses = new int[][]
            {
                new int[] { 1,2 },
            };
            var expected = 3;

            var actual = sut.ScheduleCourse(input_courses);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_courses = new int[][]
            {
                new int[] { 3,2 },
                new int[] { 4,3 },
            };
            var expected = 3;

            var actual = sut.ScheduleCourse(input_courses);

            Assert.AreEqual(expected, actual);
        }
    }
}
