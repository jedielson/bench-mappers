namespace BenchMappers.WithAutoMapper.Mappers
{
    using AutoMapper;

    using BenchMappers.Lib;
    using BenchMappers.Lib.Dto;

    public class LocalProfile : Profile
    {
        public LocalProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<Item, ItemDto>();
            CreateMap<Product, ProductDto>();

            CreateMap<OrderDto, Order>();
            CreateMap<ItemDto, Item>();
            CreateMap<ProductDto, Product>();
        }
    }
}