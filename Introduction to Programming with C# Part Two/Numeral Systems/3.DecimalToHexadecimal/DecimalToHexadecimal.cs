using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static string DecHex(int n)
        {
            List<string> array = new List<string>();
            while (n!=0)
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
                    default: res = Convert.ToString(n%16);
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

        static void Main()
        {
            Console.WriteLine("Please, enter a decimal number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number in hexadecimal is: ");
            Console.WriteLine(DecHex(n));
        }
    }
}
