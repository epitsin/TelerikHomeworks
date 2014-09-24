using System;

namespace _7.Fibonachi
{
    class Fibonachi
    {
        static void Main()
        {
            Console.WriteLine("Please, enter how long your sequence is: ");
            int n = int.Parse(Console.ReadLine());
            int firtNumber = 0;
            int secondNumber = 1;
            Console.WriteLine("Please, enter the first number: ");
            Console.WriteLine(firtNumber);
            Console.WriteLine("Please, enter the second number: ");
            Console.WriteLine(secondNumber);
            for (int i = 3; i <= n; i++)
            {
                
                int next = firtNumber + secondNumber;
                firtNumber = secondNumber;
                secondNumber = next;
                Console.Write(next + " ");
            }
        }
    }
}
