using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult JsonResult()
        {
            return Ok(CityDataStore.Instance.cities);
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id) 
        {
            return Ok(CityDataStore.Instance.cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
