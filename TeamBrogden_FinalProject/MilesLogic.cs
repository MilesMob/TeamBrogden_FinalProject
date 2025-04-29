/**
* File Name: MilesLogic.cs

* Name: Miles Jacobson
* email:  jacobst3@mail.uc.edu
* Assignment Number: Final Project
* Due Date:   04/27/25
* Course #/Section:   IS3050 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Create a .aspx site, styled with bootstrap, that solves diffrent leet code problems.

* Brief Description of what this module does: This project uses all of the skills we have praticed through out the semester to show our undrestanding of html, css, bootstrap, and .asp formats.
* Citations: Chatgpt.com,https://www.w3schools.com/bootstrap5/bootstrap_grid_system.php,https://leetcode.com/problems/sudoku-solver/description/
* Anything else that's relevant:ChatGpt used to write solver logic in leetcode problems**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamBrogden_FinalProject
{
    /// <summary>
    /// SudokuSolver Logic written by chatgpt
    /// </summary>
    public class SudokuSolver
    {
        public string Run()
        {
            char[][] board = new char[][]
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            SolveSudoku(board);

            // Format the solved board as a string
            var output = "<pre>";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    output += board[i][j] + " ";
                }
                output += "<br/>";
            }
            output += "</pre>";

            return output;
        }

        public void SolveSudoku(char[][] board)
        {
            Solve(board);
        }

        private bool Solve(char[][] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, row, col, c))
                            {
                                board[row][col] = c;
                                if (Solve(board)) return true;
                                board[row][col] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(char[][] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == c || board[i][col] == c) return false;
                if (board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == c) return false;
            }
            return true;
        }
    }
}