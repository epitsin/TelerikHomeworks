namespace TradeCompany
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Wintellect.PowerCollections;
    public class EntryPoint
    {
        public static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(true);
            var watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < 500000; i++)
            {
                var name = i.ToString();
                var price = i;

                articles[i].Add(new Article(name, price));
            }

            for (int i = 0; i < 10000; i++)
            {
                int min = i, max = i + 50;

                FindFirst20ProductsInPriceRange(articles, min, max);
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed);
        }

        public static ICollection<Article> FindFirst20ProductsInPriceRange(OrderedMultiDictionary<decimal, Article> articles, decimal min, decimal max)
        {
            return articles.Range(min, true, max, true).Values;
        }
    }
}
