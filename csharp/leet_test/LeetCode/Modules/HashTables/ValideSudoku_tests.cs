using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.ValideSudoku;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ValideSudoku_tests
    {
        [TestMethod]
        public void IsValidSudoku_example1()
        {
            var sut = new Solution();
            var expected = true;
            var input_board = new char[][] {
                  new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.' }
                , new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.' }
                , new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.' }
                , new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3' }
                , new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1' }
                , new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6' }
                , new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.' }
                , new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5' }
                , new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var actual = sut.IsValidSudoku(input_board);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidSudoku_example2()
        {
            var sut = new Solution();
            var expected = false;
            var input_board = new char[][] {
                new char[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            var actual = sut.IsValidSudoku(input_board);

            Assert.AreEqual(expected, actual);
        }
    }
}
