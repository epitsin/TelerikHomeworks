using System;
using System.Collections.Generic;
using System.Text;

namespace _5.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static string HexBin(string n)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = n.Length-1; i >= 0; i--)
            {
                List<int> currentDIgit = new List<int>();
                int res = 0;
                switch (n[i])
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
                    default: res = int.Parse(n[i].ToString());
                        break;
                }
                int j = 0;
                while (j<4)
                {
                    currentDIgit.Add(res % 2);
                    res /= 2;
                    j++;
                }
                foreach (int value in currentDIgit)
                {
                    builder.Insert(0, Convert.ToString(value));
                }
            }
            return builder.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a hexadecimal number: ");
            string n = Console.ReadLine();
            Console.WriteLine("The number in binary is: ");
            Console.WriteLine(HexBin(n));
        }
    }
}
