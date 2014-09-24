using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumZero
{
    class SumZero
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the numbers in the set: ");
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Please enter the sum you want to have: ");
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                int currentSum = array[i];
                bool breakFromEverything = false;
                if (currentSum != sum)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        currentSum += array[j];
                        if (currentSum == sum)
                        {
                            for (int k = i; k <= j; k++)
                            {
                                Console.Write(array[k]);
                            }
                            breakFromEverything = true;
                            break;
                        }
                        else if (currentSum < sum)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
                if (breakFromEverything == true)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
