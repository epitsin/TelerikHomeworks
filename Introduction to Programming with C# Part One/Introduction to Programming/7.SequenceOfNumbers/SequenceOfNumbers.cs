using System;

namespace _7.SequenceOfNumbers
{
    class SequenceOfNumbers
    {
        static void Main()
        {
            //Enter the starting number of the sequence, for example do you want it to begin from 2 or 5 or -8.
            Console.WriteLine("Please, enter the first number from the sequence.");
            int startNumber = int.Parse(Console.ReadLine());

            // How long would you like your sequence to be, for example 3, 5, 10, 20 numbers.
            Console.WriteLine("Please, enter the the length of the sequence.");
            int lengthOfSequence = int.Parse(Console.ReadLine());

            // What is the direction of the sequence, for example 5,-6,7,-8... or 5,-4,3,-2...
            Console.WriteLine("Please, write \"up\" or \"down\" for the direction of the sequence.");
            string directionOfSequence = Console.ReadLine();

            int next = startNumber;

            Console.WriteLine(next);
            for (int i = 0; i < lengthOfSequence; i++) // Using a loop to go through all the numbers in the sequence and assign them a certain value.
            {

                if (i % 2 == 0)
                {
                    if (directionOfSequence == "down")
                    {
                            next = -next +1;
                    }
                    else if (directionOfSequence == "up")
                    {
                        next = -(next + 1);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    if (directionOfSequence == "down")
                    {
                            next = -(next +1);
                    }
                    else if (directionOfSequence == "up")
                    {
                        next = -next + 1;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
                Console.WriteLine(next);
            }
        }
    }
}

