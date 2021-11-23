namespace BenchMappers.Lib.Dto
{
    using System;

    public class ItemDto
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }

        public decimal UnitPrice { get; set; }

        public double Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
