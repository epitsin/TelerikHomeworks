using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseDigits
{
    class ReverseDIgits
    {
        static int ReverseNumber(int n)
        {
            string rev = "";
            while (n != 0)
            {
                rev += n % 10;
                n /= 10;
            }
            int result = int.Parse(rev);
            return result;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }
    }
}
