using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.ValideSudoku
{
    /*
     * Valid Sudoku
     * 
     * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
     * 
     * https://leetcode.com/explore/learn/card/hash-table/185/hash_table_design_the_key/1126/
     */
    public class Solution
    {
        private char[][] board;
        private HashSet<char> set;
        public bool IsValidSudoku(char[][] board)
        {
            this.board = board;

            return CheckRows() && CheckCols() && CheckSquaresThreeByThree(); 
        }

        private bool CheckRows()
        {
            for(var i = 0; i < board.Length; i++)
            {
                set = new HashSet<char>();
                for (var j = 0; j <board[i].Length; j++)
                {
                    if(board[i][j] == '.')
                    {
                        // Do nothing
                    }
                    else if (set.Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(board[i][j]);
                    }
                }
            }

            return true;
        }

        private bool CheckCols()
        {
            for (var i = 0; i < board.Length; i++)
            {
                var set = new HashSet<int>();
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (board[j][i] == '.')
                    {
                        // Do nothing
                    }
                    else if (set.Contains(board[j][i]))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(board[j][i]);
                    }
                }
            }

            return true;
        }

        private bool CheckSquaresThreeByThree()
        { 
            var minirow = 3;
            var minicol = 3;
            
            while(minirow <= 9 && minicol <= 9)
            {
                set = new HashSet<char>();
                for(var col = minicol - 3; col < minicol; col++)
                {
                    for (var row = minirow - 3; row < minirow; row++)
                    {
                        if (board[col][row] == '.')
                        {
                            // Do nothing
                        }
                        else if (set.Contains(board[col][row]))
                        {
                            return false;
                        }
                        else
                        {
                            set.Add(board[col][row]);
                        }
                    }
                }
                
                if(minirow <= 6)
                {
                    minirow += 3;
                }
                else
                {
                    minirow = 3;
                    minicol += 3;
                }
            }

            return true;
        }
    }
}
