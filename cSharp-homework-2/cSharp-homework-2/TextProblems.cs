﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace cSharphomework2
{
    public class TextProblems
    {
        private string text;
        private int _numberProblem;
        public TextProblems()
        {
            text = "";
            _numberProblem = -1;
        }
        public TextProblems(int n)
        {
            _numberProblem = n;
            text = $"Problem №{_numberProblem} \n";
        }

        public void EditNumberProblem(int n)
        {
            _numberProblem = n;
        }
        public string makeProblemText()
        {
            try
            {
                switch (_numberProblem)
                {
                    case 1 :
                        text = $"Problem №{_numberProblem} .";
                        text = $"{text} Sort Array of Numbers \n";
                        text = $"{text} Write a program to sort an array of numbers and then print them back on the console. \n";
                        text = $"{text} The numbers should be entered from the console on a single line, separated by a space. \n";
                        break;
                    case 2 :
                        text = $"Problem №{_numberProblem} .";
                        text = $"{text} Sort Array of Numbers Using Selection Sort \n";
                        text = $"{text} Write a program to sort an array of numbers and then print them back on the console. \n";
                        text = $"{text} The numbers should be entered from the console on a single line, separated by a space. \n";
                        break;
                    case 3 :
                        text = $"Problem №{_numberProblem} .";
                        text = $"{text} Categorize Numbers \n";
                        text = $"{text} Write a program that reads N floating-point numbers from the console. \n";
                        text = $"{text} Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) \n";
                        text = $"{text} and the other containing the floating-point numbers with non-zero fraction. \n";
                        text = $"{text} Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). \n";
                        break;
                    case 4 :
                        break;
                    case 5 :
                        break;
                    case 6 :
                        break;
                    case 7 :
                        break;
                    case 8 :
                        break;
                    case 9 :
                        break;
                    default:
                        throw new Exception("Unknown problem");
                }

                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}