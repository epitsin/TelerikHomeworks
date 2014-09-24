using System;

namespace _6.IsFemale
{
    class IsFemale
    {
        static void Main()
        {
            Console.WriteLine(@"Please, write ""female"" or ""male"" for your gender.");
            string gender = Console.ReadLine(); //Reading the person's gender from the console.
            string female = "female";
            bool isFemale = false;
            if (gender == female) // Checking if gender is female or not.
            {
                isFemale = true;
            }
            Console.WriteLine("Your gender is female: " + isFemale);
        }
    }
}
