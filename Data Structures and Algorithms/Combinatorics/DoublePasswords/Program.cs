namespace DoublePasswords
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var password = Console.ReadLine();
            int countOfStars = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '*')
                {
                    countOfStars += 1;
                }
            }

            long numberOfCombinations = 1;
            for (int i = 0; i < countOfStars; i++)
            {
                numberOfCombinations *= 2;
            }

            Console.WriteLine(numberOfCombinations);
        }
    }
}
