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

        public List<ItemDto> Items { get; set; }

        public static Order FromOrderDto(OrderDto order)
        {
            return new Order
            {
                Id = order.Id,
                Code = order.Code,
                Date = order.Date,
                Items = ItemDto.FromItemDtoCollection(order.Items),
                Status = Enum.Parse<OrderStatus>(order.Status)
            };
        }
    }
}