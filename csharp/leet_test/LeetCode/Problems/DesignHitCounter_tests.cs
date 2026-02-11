using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using leet.LeetCode.ProblemsDesign.HitCounter;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class DesignHitCounter_tests
    {
        private static IEnumerable<((List<string> events, int?[] timestamp) inputs, int?[] expected)> cases()
        {
            // Test Case 1: Example 1
            yield return ((
                    new List<string>() {"HitCounter", "hit", "hit", "hit", "getHits", "hit", "getHits", "getHits" },
                    new int?[] { null , 1, 2, 3, 4, 300, 300, 301 }),
                    new int?[] { null, null, null, null, 3, null, 4, 3 }
                );

        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void DesignHitCounter_basic_tests((List<string> events, int?[] timestamp) inputs, int?[] expected)
        {
            var SUT = new HitCounter();

            if (expected.Length != inputs.events.Count || expected.Length != inputs.timestamp.Length)
                throw new ArgumentException("Invalid test arguments.");

            for (var i = 0; i < inputs.events.Count; i++)
            {
                switch(inputs.events[i])
                {
                    case "HitCounter":
                        SUT = new HitCounter();
                        break;

                    case "hit":
                        if (inputs.timestamp[i] == null)
                            throw new ArgumentException("ArgumentException should not be null");

                        SUT.Hit((int) inputs.timestamp[i]);
                        
                        break;

                    case "getHits":
                        if (inputs.timestamp[i] == null)
                            throw new ArgumentException("ArgumentException should not be null");

                        var actual = SUT.GetHits((int) inputs.timestamp[i]);

                        Assert.AreEqual(expected[i], actual);

                        break;

                    default:
                        throw new ArgumentException("Invalid test event.");

                }
            }
        }
    }
}
