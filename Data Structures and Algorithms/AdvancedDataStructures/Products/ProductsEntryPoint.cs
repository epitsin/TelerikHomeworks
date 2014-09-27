namespace Products
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class ProductsEntryPoint
    {
        public static void Main()
        {
            var products = new OrderedBag<Product>();
            var watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < 500000; i++)
            {
                var name = i.ToString();
                var price = i;

                products.Add(new Product(name, price));
            }

            for (int i = 0; i < 10000; i++)
            {
                int min = i, max = i + 50;

                FindFirst20ProductsInPriceRange(products, min, max);
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed);
        }
        public static ICollection<Product> FindFirst20ProductsInPriceRange(OrderedBag<Product> products, decimal min, decimal max)
        {
            return products.Range(new Product(string.Empty, min), true,
                                  new Product(string.Empty, max), true).Take(20).ToList();
        }
    }
}
