using Company.API.Business.Abstract;
using Company.API.Models.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }


        [HttpPost("Add")]
        public void Add(City city)
        {

            _cityService.Add(city);

        }

        [HttpDelete("Delete")]
        public void Delete(City city)
        {

            _cityService.Delete(city);

        }

        [HttpPut("Update")]
        public void Update(City city)
        {

            _cityService.Update(city);

        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _cityService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetCityOrCountryId")]
        public IActionResult GetCityOrCountryId(int countryId)
        {

            var result = _cityService.GetCityOrCountryId(countryId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }



        [HttpGet("{Id}")]
        public IActionResult City(int Id)
        {
            var result = _cityService.GetById(Id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();



        }

        [HttpGet]
        public IActionResult City(string name)
        {

            var result = _cityService.GetByCityName(name);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();


        }
    }
}
