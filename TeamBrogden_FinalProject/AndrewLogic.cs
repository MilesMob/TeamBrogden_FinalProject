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