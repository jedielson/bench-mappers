namespace BenchMappers.WithAutoMapper.Controllers
{
    using AutoMapper;

    using BenchMappers.Lib;
    using BenchMappers.Lib.Dto;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/mapping")]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;

        public OrderController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult PostAsync([FromBody] OrderDto dto)
        {
            var data = _mapper.Map<Order>(dto);
            return Ok(data);
        }
    }
}
