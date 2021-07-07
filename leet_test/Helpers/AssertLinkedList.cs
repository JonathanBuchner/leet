using leet.LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.Helpers
{
    public static class AssertLinkedList
    {
        public static void AreEqual(ListNode expected, ListNode actual)
        {
            while (expected != null && actual != null)
            {
                Assert.AreEqual(expected, actual);
                expected = expected.next;
                actual = actual.next;
            }
        }

        public static void AreEqualValue(ListNode expected, ListNode actual)
        {
            while (expected != null && actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }
    }
}
