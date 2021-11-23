namespace BenchMappers.Lib.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ItemDto
    {
        public Guid Id { get; set; }

        public ProductDto Product { get; set; }

        public decimal UnitPrice { get; set; }

        public double Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public static Item FromItemDto(ItemDto item)
        {
            return new Item
            {
                Id = item.Id,
                Product = ProductDto.FromProductDto(item.Product),
                Quantity = item.Quantity,
                TotalPrice = item.TotalPrice,
                UnitPrice = item.UnitPrice
            };
        }

        internal static List<Item> FromItemDtoCollection(List<ItemDto> items)
        {
            return items.Select(x => FromItemDto(x)).ToList();
        }
    }
}
