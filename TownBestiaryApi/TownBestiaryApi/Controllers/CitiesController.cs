using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Animals;
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

	[HttpGet("{id}/animals")]
	public ActionResult<List<Animal>> GetAnimals([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city.Animnals);
	}
	
	[HttpGet("{id}/boards")]
	public ActionResult<List<Animal>> GetBoards([FromRoute] int id) {
		var city = CityGenerator.Cities.FirstOrDefault(a => a.Id == id);
		if (city is null) {
			return NotFound();
		}

		return Ok(city.Boards);
	}
}