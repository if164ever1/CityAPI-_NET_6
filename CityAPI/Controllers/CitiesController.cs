using CityAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CityDataStore.Instance.cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var city = CityDataStore.Instance.cities.FirstOrDefault(x => x.Id == id);

            if (city == null) 
                return NotFound();

            return Ok(city);
        }
    }
}