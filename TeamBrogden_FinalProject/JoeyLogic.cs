using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamBrogden_FinalProject
{
    public class JoeyLogic
    {
        public string Run()
        {
            int[] ratings = new int[] { 1, 0, 2 }; // LeetCode test case

            int n = ratings.Length;
            int[] candies = new int[n];

            // Step 1: Give each child 1 candy
            for (int i = 0; i < n; i++)
                candies[i] = 1;

            // Step 2: Left to right
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    candies[i] = candies[i - 1] + 1;
            }

            // Step 3: Right to left
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }

            // Step 4: Sum the candies
            int total = 0;
            foreach (int c in candies)
                total += c;

            return $"Minimum candies required: {total}";
        }
    }

}

    