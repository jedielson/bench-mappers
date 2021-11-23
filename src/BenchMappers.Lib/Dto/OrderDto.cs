namespace BenchMappers.Lib.Dto
{
    using System;
    using System.Collections.Generic;

    public class OrderDto
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public List<Item> Items { get; set; }
    }
}