using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models;
using TownBestiaryApi.MoqData;

namespace TownBestiaryApi.Controllers; 
[ApiController]
[Route("[controller]")]

public class CitiesController : ControllerBase {

	[HttpGet]
	public ActionResult<List<City>> Get() {
		return CityGenerator.Cities;
	}

	[HttpGet("{id}")]
	public ActionResult<City> GetById([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city);
	}
}