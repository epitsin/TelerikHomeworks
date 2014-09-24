//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SeiveOfEratosthenes
{
    class SeiveOfEratosthenes
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number between 1 and 10000000: ");
            Console.WriteLine("If your number is too big, you will have to wait for the programme to compute the numbers :)");

            // SLOWER VERSION
            int n = int.Parse(Console.ReadLine());
            Stopwatch time = new Stopwatch();
            time.Start();
            List<int> array = new List<int>();
            for (int i = 2; i < n; i++)
            {
                array.Add(i);
            }
            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[j] % array[i] == 0)
                    {
                        array.Remove(array[j]);
                    }
                }
            }
            Console.WriteLine("The prime numbers are: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            time.Stop();
            Console.WriteLine(time.Elapsed);

            // FASTER VERSION
            time.Reset();
            time.Start();
            StringBuilder build = new StringBuilder();
            for (int j = 2; j < n; j++)
            {
                bool prime = true;
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (j % i == 0 && j != i)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    build.AppendFormat("{0} ", j);
                }
            }
            Console.WriteLine(build.ToString());
            time.Stop();
            Console.WriteLine(time.Elapsed);
        }
    }
}
