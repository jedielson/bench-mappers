namespace BenchMappers.Lib
{
    using System;

    public class Item
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }

        public decimal UnitPrice { get; set; }

        public double Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
