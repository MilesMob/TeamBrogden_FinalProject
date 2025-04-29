/*File Name: TeamBrogden_FinalProject

* Name: Andrew Luce
* email:  luceag@mail.uc.edu
* Assignment Number: Assignment Final
* Due Date:   April 28 2025
* Course #/Section:   IS3050001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  This is our final project which we will create leetcode
*  that we will share with our team through github
* Brief Description of what this module does. This module is teaching us ASP.NET
* Citations: Chatgpt.com https://leetcode.com/problems/cracking-the-safe/description/
* Anything else that's relevant: n/a
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TeamBrogden_FinalProject
{
    public class AndrewLogic
    {
        public string Run()
        {
            int n = 2; // Length of each password combination
            int k = 2; // Digits 0 to k-1

            var visited = new HashSet<string>();
            var sb = new StringBuilder();
            string start = new string('0', n - 1); // Starting prefix, e.g., "0" if n = 2

            DFS(start, visited, sb, k, n);

            sb.Append(start); // Append the start prefix at the end
            return sb.ToString(); // Final result
        }

        private void DFS(string node, HashSet<string> visited, StringBuilder sb, int k, int n)
        {
            for (int i = 0; i < k; i++)
            {
                string edge = node + i;
                if (!visited.Contains(edge))
                {
                    visited.Add(edge);
                    DFS(edge.Substring(1), visited, sb, k, n);
                    sb.Append(i);
                }
            }
        }
    }
}