using leet.LeetCode.ReverseString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode
{
    [TestClass]
    public class ReverseString_tests
    {
        [TestMethod]
        public void Example1_can_reverse_string_of_odd_list()
        {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new char[] { 'o', 'l', 'l', 'e', 'h'};
            var sut = new Solution();

            sut.ReverseString(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Example2_can_reverse_string_with_capitals_and_even_list()
        {
            var input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h'};
            var expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };
            var sut = new Solution();

            sut.ReverseString(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}
