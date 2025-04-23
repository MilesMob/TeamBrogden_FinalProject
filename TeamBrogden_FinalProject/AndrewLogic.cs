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

            var numberOfStates = (int)Math.Pow(k, n - 1);

            var result = new LinkedList<int>();
            var states = new Dictionary<int, int>();
            for (var i = 0; i < numberOfStates; i++)
            {
                states[i] = 0;
            }

            void Dfs(int state, int symbol)
            {
                var nextStateBase = state * k % numberOfStates;

                while (states[state] < k)
                {
                    var currentValue = states[state];
                    var nextState = (nextStateBase + currentValue) % numberOfStates;
                    var nextStateCurrentValue = states[nextState];
                    states[state] = currentValue + 1;

                    Dfs(nextState, currentValue);
                }
                result.AddFirst(symbol);

            }

            Dfs(0, 0);
            result.RemoveFirst();
            foreach (var i in Enumerable.Range(0, n - 1))
            {
                result.AddFirst(0);
            }
            var resultString = String.Join("", result.AsEnumerable());
            return resultString;
        }
    }
}