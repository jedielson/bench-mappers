namespace BenchMappers.Benchmark
{
    using System.Threading.Tasks;

    using AutoFixture;

    using BenchMappers.Lib;
    using BenchMappers.Lib.Dto;

    using BenchmarkDotNet.Attributes;

    using Microsoft.AspNetCore.Mvc.Testing;

    using Refit;

    public interface IOrderClient
    {
        [Post("/api/mapping")]
        Task Post([Body] OrderDto order);
    }

    [HtmlExporter]
    public class Mapping
    {
        private static readonly WebApplicationFactory<SimpleMapper.Startup> _simpleMapperFactory = new();
        private static readonly WebApplicationFactory<WithAutoMapper.Startup> _autoMapperFactory = new();

        public static readonly IOrderClient SimpleMapperClient = RestService.For<IOrderClient>(_simpleMapperFactory.CreateClient());
        public static readonly IOrderClient AutoMapperClient = RestService.For<IOrderClient>(_autoMapperFactory.CreateClient());

        private static readonly Fixture _fixture = new();

        [Benchmark(Baseline = true)]
        public async Task GetSimpleMapper()
        {
            var data = _fixture.Build<OrderDto>()
                            .With(x => x.Status, OrderStatus.Requested.ToString())
                            .Create();

            await SimpleMapperClient.Post(data);
        }

        [Benchmark]
        public async Task GetAutoMapper()
        {
            var data = _fixture.Build<OrderDto>()
                            .With(x => x.Status, OrderStatus.Requested.ToString())
                            .Create();


            await AutoMapperClient.Post(data);
        }
    }
}