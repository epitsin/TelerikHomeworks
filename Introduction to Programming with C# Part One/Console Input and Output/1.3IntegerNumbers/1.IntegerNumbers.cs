using System;

namespace _3IntegerNumbers
{
    class IntegerNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first number: ");
            int a = 0;
            while (true)
            { 
                string str1 = Console.ReadLine();
                if (int.TryParse(str1, out a))
                {
                    break;
                }
            }
            Console.WriteLine("Please, enter the second number: ");
            int b = 0;
            while (true)
            {
                string str2 = Console.ReadLine();
                if (int.TryParse(str2, out b))
                {
                    break;
                }
            }
            Console.WriteLine("Please, enter the third number: ");
            int c = 0;
            while (true)
            {
                string str3 = Console.ReadLine();
                if ( int.TryParse(str3, out c))
                {
                    break;
                }
            }
            int sum = a + b + c;
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
