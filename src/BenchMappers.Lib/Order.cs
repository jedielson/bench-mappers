namespace BenchMappers.Lib
{
    using System;
    using System.Collections.Generic;

    public enum OrderStatus
    {
        None,
        Requested,
        WaitingPayment,
        InTransit,
        Done,
        Canceled
    }

    public class Order
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public DateTime Date { get; set; }

        public OrderStatus Status { get; set; }

        public List<Item> Items { get; set; }
    }
}