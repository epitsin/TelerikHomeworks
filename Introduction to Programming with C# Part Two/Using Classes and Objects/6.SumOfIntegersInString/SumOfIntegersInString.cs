using System;

namespace _6.SumOfIntegersInString
{
    class SumOfIntegersInString
    {
        static int FindSum(char[] input)
        {
            int sum = 0;
            string currentNumber = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    currentNumber += input[i];
                }
                else
                {
                    sum += int.Parse(currentNumber);
                    currentNumber = "";
                }
            }
            sum += int.Parse(currentNumber);
            return sum;
        }

        static void Main()
        {
            string input = "43 68 9 23 318";
            Console.WriteLine(FindSum(input.ToCharArray()));
        }
    }
}


//public static void Main()
//    {
//        string input = "43 68 9 23 318";
//        int sum = 0;
//        string[] strNums = input.Split(' ');
//        for (int i = 0; i < strNums.Length; i++)
//        {
//            sum = sum + int.Parse(strNums[i].Trim());
//        }

//        Console.WriteLine(sum);
//    }
