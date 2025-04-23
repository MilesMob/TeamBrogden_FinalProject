using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamBrogden_FinalProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            LabelProblem.Text="";
            LabelTest.Text = "";
            LabelSolution.Text="";
            Image2.Visible=false;

        }
        /// <summary>
        ///  Sets image to sudoku puzzle and makes it visable, then sets label text to the the leetcode problem and runs the solution, putting the output in label solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MilesButton_Click(object sender, EventArgs e)
        {
            Image2.ImageUrl = "SudokuImage.png";
            Image2.Visible = true;
            LabelProblem.Text="Write a program to solve a Sudoku puzzle by filling the empty cells.\r\n\r\nA sudoku solution must satisfy all of the following rules:\r\n\r\nEach of the digits 1-9 must occur exactly once in each row.\r\nEach of the digits 1-9 must occur exactly once in each column.\r\nEach of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.\r\nThe '.' character indicates empty cells.";
            var solver = new SudokuSolver();
            LabelSolution.Text = solver.Run();
        }

        protected void AndrewButton_Click(object sender, EventArgs e)
        {
            LabelProblem.Text = "There is a safe protected by a password. The password is a sequence of n digits where each digit can be in the range [0, k - 1].\r\n\r\nThe safe has a peculiar way of checking the password. When you enter in a sequence, it checks the most recent n digits that were entered each time you type a digit.\r\n\r\nFor example, the correct password is \"345\" and you enter in \"012345\":\r\nAfter typing 0, the most recent 3 digits is \"0\", which is incorrect.\r\nAfter typing 1, the most recent 3 digits is \"01\", which is incorrect.\r\nAfter typing 2, the most recent 3 digits is \"012\", which is incorrect.\r\nAfter typing 3, the most recent 3 digits is \"123\", which is incorrect.\r\nAfter typing 4, the most recent 3 digits is \"234\", which is incorrect.\r\nAfter typing 5, the most recent 3 digits is \"345\", which is correct and the safe unlocks.\r\nReturn any string of minimum length that will unlock the safe at some point of entering it.";
            LabelTest.Text = "(n=2, k=2)";
            var result = new AndrewLogic().Run();
            LabelSolution.Text = "Generated Sequence: " + result;

        }

        protected void JoeyButton_Click(object sender, EventArgs e)
        {

        }

        protected void RhodaButton_Click(object sender, EventArgs e)
        {

        }

    }
}
