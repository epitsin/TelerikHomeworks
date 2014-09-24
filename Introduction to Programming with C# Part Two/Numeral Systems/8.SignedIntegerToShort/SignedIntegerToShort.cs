using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SignedIntegerToShort
{
    class SignedIntegerToShort
    {
        static string DecBin(int n)
        {
            StringBuilder builder = new StringBuilder();
            if (n < 0)
            {
                n = 65535 + n + 1;
            }
            while (n != 0)
            {
                builder.Insert(0, n % 2);
                n /= 2;
            }
            return builder.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a signed number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number in binary is: ");
            Console.WriteLine(DecBin(n));            
        }
    }
}
