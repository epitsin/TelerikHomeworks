using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static string BinHex(string n)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = n.Length - 1; i >= 0; i-=4)
            {
                double currentDigit = 0;
                int power = 0;
                for (int j = i; j > i - 4 && j>=0; j--)
                {
                    currentDigit += Math.Pow(2, power) * Convert.ToInt32(n[j].ToString());
                    power++;
                }
                string res = "";
                switch ((int)currentDigit)
                {
                    case 10: res = "A";
                        break;
                    case 11: res = "B";
                        break;
                    case 12: res = "C";
                        break;
                    case 13: res = "D";
                        break;
                    case 14: res = "E";
                        break;
                    case 15: res = "F";
                        break;
                    default: res = currentDigit.ToString();
                        break;
                }
                builder.Insert(0, res);
            }
            return builder.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a binary number: ");
            string n = Console.ReadLine();
            Console.WriteLine("The number in hexadecimal is: ");
            Console.WriteLine(BinHex(n));
        }
    }
}
