using System;

namespace _4.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static double HexDec(string n)
        {
            double result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int res = 0;
                switch (n[n.Length - 1 - i])
                {
                    case 'A': res = 10;
                        break;
                    case 'B': res = 11;
                        break;
                    case 'C': res = 12;
                        break;
                    case 'D': res = 13;
                        break;
                    case 'E': res = 14;
                        break;
                    case 'F': res = 15;
                        break;
                    default: res = int.Parse(n[n.Length-1-i].ToString());
                        break;
                }
                result += Math.Pow(16, i) * res;
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a hexadecimal number: ");
            string n = Console.ReadLine();
            Console.WriteLine("The number in decimal is: ");
            Console.WriteLine(HexDec(n));
        }
    }
}
