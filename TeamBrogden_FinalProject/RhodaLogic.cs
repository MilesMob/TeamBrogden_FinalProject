/**File Name: TeamBrogden_FinalProject
Studet Name: Rhoda Asiamah
Email: asiamaro@mail.uc.edu
Assignment #: Final Project
Due date: Beginning of class, 9:15am 04 / 29 / 25
Section: IS3050 001
Semester / Year: Spring 2025
Brief Description: Showing knowledge of C#
What module does: Go over aspx, web forms, creating classes, aspx buttons, tables, lists, etc.
Citations:
Anything relevant: Learning many different ways to edit
**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamBrogden_FinalProject
{
    public class RhodaLogic
    {
        public class Solution
        {
            public int Trap(int[] height)
            {
                int left = 0, right = height.Length - 1;
                int leftMax = 0, rightMax = 0;
                int water = 0;

                while (left < right)
                {
                    if (height[left] < height[right])
                    {
                        if (height[left] >= leftMax)
                        {
                            leftMax = height[left];
                        }
                        else
                        {
                            water += leftMax - height[left];
                        }
                        left++;
                    }
                    else
                    {
                        if (height[right] >= rightMax)
                        {
                            rightMax = height[right];
                        }
                        else
                        {
                            water += rightMax - height[right];
                        }
                        right--;
                    }
                }

                return water;
            }
        }
    }
}