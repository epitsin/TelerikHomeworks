using System;

namespace _10.Scores
{
    class Scores
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a score: ");
            int number = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out number))
                {
                    break;
                }
            }
            switch (number)
            {
                case (1):
                    {
                        number = number * 10;
                        Console.WriteLine(number);
                    }
                    break;
                case (2):
                    {
                        number = number * 10;
                        Console.WriteLine(number);
                    }
                    break;
                case (3):
                    {
                        number = number * 10;
                        Console.WriteLine(number);
                    }
                    break;
                case (4):
                    {
                        number = number * 100;
                        Console.WriteLine(number);
                    }
                    break;
                case (5):
                    {
                        number = number * 100;
                        Console.WriteLine(number);
                    }
                    break;
                case (6):
                    {
                        number = number * 100;
                        Console.WriteLine(number);
                    }
                    break;
                case (7):
                    {
                        number = number * 1000;
                        Console.WriteLine(number);
                    }
                    break;
                case (8):
                    {
                        number = number * 1000;
                        Console.WriteLine(number);
                    }
                    break;
                case (9):
                    {
                        number = number * 1000;
                        Console.WriteLine(number);
                    }
                    break;
                case (0):
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                    
            }
        }
    }
}
