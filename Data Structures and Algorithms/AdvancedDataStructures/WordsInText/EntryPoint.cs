namespace WordsInText
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Counting words...");
            DateTime start = DateTime.Now;
            TrieNode root = new TrieNode(null, '?');
            Dictionary<DataReader, Thread> readers = new Dictionary<DataReader, Thread>();

            var args = "../../trie.txt";

            DataReader dataReader = new DataReader(args, ref root);
            Thread thread = new Thread(dataReader.ThreadRun);
            readers.Add(dataReader, thread);
            thread.Start();

            foreach (Thread t in readers.Values)
            {
                t.Join();
            }

            DateTime stop = DateTime.Now;
            Console.WriteLine("Input data processed in {0} secs", new TimeSpan(stop.Ticks - start.Ticks).TotalSeconds);
            Console.WriteLine();
            Console.WriteLine("Most commonly found words:");

            List<TrieNode> topTenMostUsedWords = new List<TrieNode> { root, root, root, root, root, root, root, root, root, root };
            int distinctWordCount = 0;
            int totalWordCount = 0;
            root.GetTopCounts(ref topTenMostUsedWords, ref distinctWordCount, ref totalWordCount);
            topTenMostUsedWords.Reverse();
            foreach (TrieNode node in topTenMostUsedWords)
            {
                Console.WriteLine("{0} - {1} times", node.ToString(), node.WordCount);
            }

            Console.WriteLine();
            Console.WriteLine("{0} words counted", totalWordCount);
            Console.WriteLine("{0} distinct words found", distinctWordCount);
            Console.WriteLine();
            Console.WriteLine("done.");
        }
    }
}