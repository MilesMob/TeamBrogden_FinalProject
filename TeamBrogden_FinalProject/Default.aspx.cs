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
            LabelTest.Text = "Input: (n=2, k=2)";
            var result = new AndrewLogic().Run();
            LabelSolution.Text = "Generated Sequence: " + result;

        }

        protected void JoeyButton_Click(object sender, EventArgs e)
        {
            LabelProblem.Text="There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.\r\n\r\nYou are giving candies to these children subjected to the following requirements:\r\n\r\nEach child must have at least one candy.\r\nChildren with a higher rating get more candies than their neighbors.\r\nReturn the minimum number of candies you need to have to distribute the candies to the children.\r\n\r\n ";
            LabelTest.Text="Input: ratings = [1,0,2]\r\nOutput: 5\r\nExplanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.";
            var result = new JoeyLogic().Run();
            LabelSolution.Text = result;

        }

        protected void RhodaButton_Click(object sender, EventArgs e)
        {
            LabelProblem.Text = "Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.";
            Image2.ImageUrl = "rainwatertrap.png";
            Image2.Visible = true;
            LabelTest.Text = "Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]";
            var result = new RhodaProblem().Run();
            LabelSolution.Text = result;
        }

    }
}
