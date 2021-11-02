using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.GroupAnagrams;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class GroupAnagrams_tests
    {
        [TestMethod]
        public void GroupAnagrams()
        {
            var sut = new Solution();
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<List<string>>();
            expected.Add(new List<string>() { "bat" });
            expected.Add(new List<string>() { "nat", "tan" });
            expected.Add(new List<string>() { "ate", "eat", "tea" });

            var actual = sut.GroupAnagrams(input);

            Assert.IsFalse(true);
        }
    }
}
