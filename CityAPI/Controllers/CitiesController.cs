using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet("jsonresult")]
        public IActionResult JsonResult()
        {
            var cities = new[]
            {
                new {id = 1, Name = "Lwiw"},
                new {id = 2, Name = "Ivano-Frankivsk"}
            };

            return Ok(cities);
        }
    }
}
