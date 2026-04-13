using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.DecodeTheSlantedCiphertext;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class DecodeTheSlantedCiphertext_tests
    {
        private static IEnumerable<(string encodedText, int rows, string expected)> cases()
        {
            yield return (
                "ch   ie   pr",
                3,
                "cipher"
            );

            yield return (
               "iveo    eed   l te   olc",
               4,
               "i love leetcode"
           );

            yield return (
               "coding",
               1,
               "coding"
           );

          yield return (
               "",
               1,
               ""
           );

           yield return (
              "a ",
              2,
              "a"
          );

          yield return (
              "iveo    eed   l t    olc",
              4,
              "i love leetcod"
          );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void DecodeTheSlantedCiphertext_basic_tests(string encodedText, int rows, string expected)
        {
            var SUT = new Solution();

            var actual = SUT.DecodeCiphertext(encodedText, rows);

            Assert.AreEqual(expected, actual);
        }
    }
}
