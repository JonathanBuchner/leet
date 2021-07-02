using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.GroupAnagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;
using leet_test.Helpers;

namespace leet_test.LeetCode
{
    [TestClass]
    public class GroupAnagrams_tests
    {
        [TestMethod]
        public void Example1_Can_group_anagrams()
        {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<IList<string>>()
           {
                new List<string>(){ "bat" },
                new List<string>(){ "nat", "tan" },
                new List<string>(){ "ate", "eat", "tea"}
            };
            var sut = new Solution();

            var actual = sut.GroupAnagrams(input);

            AssertTwoDementionalLists.AreMatch(expected, actual);
        }
    }
}
