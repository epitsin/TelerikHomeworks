namespace BiDictionary
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            var biDictionary = new BiDictionary<int, char, string>(true);

            biDictionary.Add(1, 'a', "first");
            biDictionary.Add(1, 'b', "second");
            biDictionary.Add(1, 'c', "third");

            biDictionary.Add(2, 'a', "fourth");
            biDictionary.Add(2, 'b', "fifth");
            biDictionary.Add(2, 'c', "sixth");

            Console.WriteLine("All values in the BiDictionary:");
            foreach (var value in biDictionary)
            {
                Console.WriteLine("    " + value);
            }

            Console.WriteLine("Find by first key = 1:");
            Console.WriteLine("    " + string.Join(", ", biDictionary.FindByFirstKey(1)));

            Console.WriteLine("Find by second key = a:");
            Console.WriteLine("    " + string.Join(", ", biDictionary.FindBySecondKey('a')));

            Console.WriteLine("Find by first and second key = 1, b:");
            Console.WriteLine("    " + string.Join(", ", biDictionary.FindByFirstAndSecondKey(1, 'b')));
            
            biDictionary.RemoveByFirstKey(1);
            biDictionary.RemoveBySecondKey('c');
            biDictionary.RemoveByFirstAndSecondKey(2, 'a');

            Console.WriteLine("All values in the BiDictionary after we remove first key = 1, second key = c and both keys = 2, a:");
            foreach (var value in biDictionary)
            {
                Console.WriteLine("    " + value);
            }

            biDictionary.Clear();
        }
    }
}
