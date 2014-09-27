namespace TradeCompany
{
    using System;

    public class Article : IComparable<Article>
    {
        public Article(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }

        public string Barcode { get; set; }

        public string Title { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return (int)(this.Price - other.Price);
        }
    }
}
