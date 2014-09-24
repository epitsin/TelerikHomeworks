using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AnySystemToAnySystem
{
    class AnySytemToAnySystem
    {
        static string DecBin(int n)
        {
            StringBuilder builder = new StringBuilder();
            while (n != 0)
            {
                builder.Insert(0, n % 2);
                n /= 2;
            }
            return builder.ToString();
        }

        static double BinDec(string n)
        {
            double result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                result += Math.Pow(2, i) * Convert.ToInt32(n[n.Length - 1 - i].ToString());
            }
            return result;
        }

        static string DecHex(int n)
        {
            List<string> array = new List<string>();
            while (n != 0)
            {
                string res = "";
                switch (n % 16)
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
                    default: res = Convert.ToString(n % 16);
                        break;
                }
                array.Add(res);
                n /= 16;
            }
            array.Reverse();
            string result = "";
            foreach (string value in array)
            {
                result += value;
            }
            return result;
        }

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
                    default: res = int.Parse(n[n.Length - 1 - i].ToString());
                        break;
                }
                result += Math.Pow(16, i) * res;
            }
            return result;
        }

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

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the numeral system of the number you wan to convert (decimal, binary or hexadecimal)");
            string input = Console.ReadLine();
            Console.WriteLine("Please, enter the numeral system you want to convert your number to (decimal, binary or hexadecimal)");
            string final = Console.ReadLine();
            if ((input == "decimal" && final == "decimal") || (input == "binary" && final == "binary") || (input == "hexadecimal" && final == "hexadecimal"))
            {
                Console.WriteLine(input);
            }
            else if (input == "decimal" && final == "binary")
            {
                Console.WriteLine(DecBin(int.Parse(input)));
            }
            else if (input == "decimal" && final == "hexadecimal")
            {
                Console.WriteLine(DecHex(int.Parse(input)));
            }
            else if (input == "binary" && final == "decimal")
            {
                Console.WriteLine(BinDec(input));
            }
            else if (input == "binary" && final == "hexadecimal")
            {
                Console.WriteLine(BinHex(input));
            }
            else if (input == "hexadecimal" && final == "binary")
            {
                Console.WriteLine(HexBin(input));
            }
            else if (input == "hexadecimal" && final == "decimal")
            {
                Console.WriteLine(HexDec(input));
            }
        }
    }
}
