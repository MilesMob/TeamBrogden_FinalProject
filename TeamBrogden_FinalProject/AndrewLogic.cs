using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TeamBrogden_FinalProject
{
    public class AndrewLogic
    {
        public string CrackSafe(int n, int k)
        {
            HashSet<string> seen = new HashSet<string>();
            StringBuilder sb = new StringBuilder();
            string start = new string('0', n - 1);

            void Dfs(string node)
            {
                for (int x = 0; x < k; x++)
                {
                    string edge = node + x;
                    if (!seen.Contains(edge))
                    {
                        seen.Add(edge);
                        Dfs(edge.Substring(1));
                        sb.Append(x);
                    }
                }
            }

            Dfs(start);
            sb.Append(start);
            return sb.ToString();
        }
    }
}
