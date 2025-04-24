<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TeamBrogden_FinalProject.WebForm1" %>
<!-- File Name: Defualt.aspx

* Name: Miles Jacobson, Andrew Luce, Joey King, Rhoda Asiamah
* email:  jacobst3@mail.uc.edu
* Assignment Number: Final Project
* Due Date:   04/27/25
* Course #/Section:   IS3050 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Create a .aspx site, styled with bootstrap, that solves diffrent leet code problems.

* Brief Description of what this module does: This project uses all of the skills we have praticed through out the semester to show our undrestanding of html, css, bootstrap, and .asp formats.
* Citations: Chatgpt.com,https://www.w3schools.com/bootstrap5/bootstrap_grid_system.php,https://leetcode.com/problems/sudoku-solver/description/
* Anything else that's relevant:ChatGpt used to write solver logic in leetcode problems
    --> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Team Brogden Final</title>
    <meta name="viewport" content="width=device-width, intial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js" type="javascript"></script>
    <script src="Scripts/bootstrap.min.js" type="javascript"></script>


</head>
<body>
    <form id="form1" runat="server">


        <div class="container border border-5">
            <!-- Heading -->
            <div class="row mb-4">
                <div class="col-m-6">

                    <h1>Team Brogden Final Project</h1>
                    <p>Team Members: Miles Jacobson, Andrew Luce, Joey King, Rhoda Asiamah</p>
                </div>
            </div>


            <!-- Buttons -->
            <div class="row mb-4">
                <div class="col-md-12">
                    <asp:Button ID="ResetButton" runat="server" Text="Reset" OnClick="ResetButton_Click" CssClass="btn btn-dark me-2 mb-2" />
                    <asp:Button ID="MilesButton" runat="server" Text="Problem 37. Sudoku Solver" OnClick="MilesButton_Click" CssClass="btn btn-info me-2 mb-2" />
                    <asp:Button ID="AndrewButton" runat="server" Text="Andrew's Problem" OnClick="AndrewButton_Click" CssClass="btn btn-light me-2 mb-2" />
                    <asp:Button ID="JoeyButton" runat="server" Text="Joey's Problem" OnClick="JoeyButton_Click" CssClass="btn btn-danger me-2 mb-2" />
                    <asp:Button ID="RhodaButton" runat="server" Text="Rhoda's Problem" OnClick="RhodaButton_Click" CssClass="btn btn-warning me-2 mb-2" />
                </div>
            </div>

            <!-- LabelProblem -->
            <div class="row mb-3" >
                <div class="col">
                    <asp:Label ID="LabelProblem" runat="server" CssClass="form-text text-muted" />
                </div>
            </div>

            <!-- Image + Solution-->
            <div class="row">
                <div class="col-md-4">
                    <asp:Image ID="Image2" runat="server" Height="209px" Width="212px" Visible="false" />
                </div>
                <div class="col-md-8">
                    <asp:Label ID="LabelSolution" runat="server" CssClass="form-control-plaintext" />
                </div>
            </div>

        </div>















    </form>
</body>
</html>
