//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

namespace CorrectBracketsInExpression
{
    class CorrectBracketsInExpression
    {
        static bool CorrectBrackets (string input)
        {
            bool correct = true;
            int i = 0;
            while(i<input.Length)
            {
                if (input[i]=='(')
                {
                    int indexClose = input.IndexOf(')', i);
                    input = input.Remove(i, 1);
                    input = input.Remove(indexClose-1, 1);
                }
                else if (input[i]==')')
                {
                    correct = false;
                    break;
                }
                else
                {
                    i++;
                }
            }
            int closeLeft = input.IndexOf(')');
            if (closeLeft >=0)
            {
                correct = false;
            }
            return correct;
        }
        static void Main()
        {
            string input = "))((ygh";
            Console.WriteLine(CorrectBrackets(input));
        }
    }
}
