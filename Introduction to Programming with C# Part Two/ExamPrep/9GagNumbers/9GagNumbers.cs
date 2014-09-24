using System;
using System.Collections.Generic;
using System.Numerics;

namespace _9GagNumbers
{
    class GagNumbers
    {
        static void Main()
        {
            string decrypted = Console.ReadLine();
            string input = decrypted;
            string sub = string.Empty;
            BigInteger result = 0;
            sub = string.Empty;
            bool found = false;
            List<int> numbers = new List<int>();
            for (int i = 0; i < decrypted.Length; i++)
            {
                sub += decrypted[i];
                switch (sub)
                {
                    case "-!": numbers.Add(0); found = true; break;
                    case "**": numbers.Add(1); found = true; break;
                    case "!!!": numbers.Add(2); found = true; break;
                    case "&&": numbers.Add(3); found = true; break;
                    case "&-": numbers.Add(4); found = true; break;
                    case "!-": numbers.Add(5); found = true; break;
                    case "*!!!": numbers.Add(6); found = true; break;
                    case "&*!": numbers.Add(7); found = true; break;
                    case "!!**!-": numbers.Add(8); found = true; break;
                }
                if (found)
                {
                    sub = string.Empty;
                    found = false;
                }
            }
            int pow = numbers.Count - 1;

            foreach (var number in numbers)
            {
                BigInteger power = 1;
                for (int i = 0; i < pow; i++)
                {
                    power *= 9;
                }
                result += number * power;
                pow--;
            }

            Console.WriteLine(result);
        }
    }
}
