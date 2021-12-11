using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Generators;
using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Animals;

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

	[HttpGet("{id}/species")]
	public ActionResult<List<Species>> GetSpecies([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city.Species);
	}
	
	[HttpGet("{id}/boards")]
	public ActionResult<List<Species>> GetBoards([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city.Boards);
	}
	
	[HttpGet("{id}/events")]
	public ActionResult<List<Species>> GetEvents([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city.Boards);
	}
}