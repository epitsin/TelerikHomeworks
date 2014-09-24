using System;

namespace LetterIndexesOfAWord
{
    class LetterIndexesOfAWord
    {
        static void Main()
        {
            int[] letters = new int[52];

            for (int i = 0; i < 26; i++)
            {
                letters[i] = (int)('A') + i;
            }

            for (int i = 26, m = 0; i < 52; i++, m++)
            {
                letters[i] = (int)('a') + m;
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.WriteLine("The index of {0} is {1}.", word[i], j);
                        break;
                    }
                }
            }
        }
    }
}
