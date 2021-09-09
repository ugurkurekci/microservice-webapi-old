using Company.API.Business.Abstract;
using Company.API.Models.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _countryService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public void Add(Country country)
        {
            _countryService.Add(country);
        }

        [HttpGet]
        public IActionResult GetCountryByName(string name)
        {
            var result = _countryService.GetCountryByName(name);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpGet("Code")]
        public IActionResult GetCountryCodeId(string name)
        {
            var result = _countryService.GetCountryCodeId(name);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("numeric")]
        public IActionResult GetByCountryNumericId(int id)
        {
            var result = _countryService.GetCountryNumericId(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {

            var result = _countryService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
    }
}
