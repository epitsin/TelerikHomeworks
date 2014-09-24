using System;

namespace Carpets
{
    class Carpets
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number / 2; i++)
            {
                for (int j = 1; j <= number / 2; j++)
                {
                    if ((number / 2) % 2 != 0)
                    {
                        if (j < number / 2 + 1 - i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@"/");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j < number / 2 + 1 - i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@" ");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write("/");
                        }
                    }
                }
                for (int j = number / 2 + 1; j <= number; j++)
                {
                    if ((number / 2) % 2 != 0)
                    {
                        if (j > number / 2 + i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(@"\");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j > number / 2 + i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@"\");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(@" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= number / 2; i++)
            {
                for (int j = 1; j <= number / 2; j++)
                {
                    if ((number / 2) % 2 != 0)
                    {
                        if (j < i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@"\");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(@" ");
                        }
                    }
                    else
                    {
                        if (j < i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@"\");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(" ");
                        }
                    }
                }
                for (int j = number / 2 + 1; j <= number; j++)
                {
                    if ((number / 2) % 2 != 0)
                    {
                        if (j > number + 1 - i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(@"/");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j > number + 1 - i)
                        {
                            Console.Write(".");
                        }
                        else if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                        {
                            Console.Write(@" ");
                        }
                        else if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0))
                        {
                            Console.Write(@"/");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
