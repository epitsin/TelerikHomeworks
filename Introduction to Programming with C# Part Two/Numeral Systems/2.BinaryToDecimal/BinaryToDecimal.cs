using System;

namespace _2.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static double BinDec(string n)
        {
            double result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                result += Math.Pow(2, i) * Convert.ToInt32(n[n.Length - 1 - i].ToString());
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a binary number: ");
            string n = Console.ReadLine();
            Console.WriteLine("The number in decimal is: ");
            Console.WriteLine(BinDec(n));
        }
    }
}
