using leet.LeetCode.Microsoft.ArrayStrings.ReverseWordsInAstring2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Microsoft.ArraysStrings
{
    [TestClass]
    public class ReverseWordsInAstring2_tests
    {
        [TestMethod]
        public void Example1_Can_reverse_an_even_phrase()
        {
            var input = new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            var expected = new char[] { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', ' ', 't', 'h', 'e' };
            var sut = new Solution();

            sut.ReverseWords(input);

            Assert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Example2_Can_reverse_an_odd__word()
        {
            var input = new char[] { 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            var expected = new char[] { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', };
            var sut = new Solution();

            sut.ReverseWords(input);

            Assert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Example3_Can_reverse_a_word()
        {
            var input = new char[] { 't', 'h', 'e' };
            var expected = new char[] { 't', 'h', 'e' };
            var sut = new Solution();

            sut.ReverseWords(input);

            Assert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Example4_Can_reverse_a_letter()
        {
            var input = new char[] { 't' };
            var expected = new char[] { 't' };
            var sut = new Solution();

            sut.ReverseWords(input);

            Assert.AreEqual(expected, input);
        }
    }
}
