namespace ColourfulRabbits
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var countOfQuestionedRabbits = int.Parse(Console.ReadLine());
            var uniqueAnswers = new Dictionary<int, int>();
            var countOfRabbits = 0;
            for (int i = 0; i < countOfQuestionedRabbits; i++)
            {
                var currentAnswer = int.Parse(Console.ReadLine());
                if (!uniqueAnswers.ContainsKey(currentAnswer))
                {
                    uniqueAnswers.Add(currentAnswer, 0);
                }

                uniqueAnswers[currentAnswer] += 1;
            }

            foreach (var answer in uniqueAnswers)
            {
                var count = answer.Value;
                if (answer.Value > answer.Key + 1)
                {
                    count = answer.Value / (answer.Key + 1);
                    if (answer.Value % (answer.Key + 1) != 0)
                    {
                        count += 1;
                    }

                    countOfRabbits += count * (answer.Key + 1);
                }
                else
                {
                    countOfRabbits += (answer.Key + 1);
                }
            }

            Console.WriteLine(countOfRabbits);
        }
    }
}
