namespace BenchMappers.SimpleMapper.Controllers
{
    using BenchMappers.Lib.Dto;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [ApiController]
        [Route("api/mapping")]
        public class OrderController : ControllerBase
        {

            public OrderController()
            {
            }

            [HttpPost]
            public ActionResult PostAsync([FromBody] OrderDto dto)
            {
                var data = OrderDto.FromOrderDto(dto);
                return Ok(data);
            }
        }
    }
}
