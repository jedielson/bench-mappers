namespace BenchMappers.Lib.Dto
{
    using System;

    public class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public static Product FromProductDto(ProductDto product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
