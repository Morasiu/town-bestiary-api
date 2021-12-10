using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models;

namespace TownBestiaryApi.Controllers; 
[ApiController]
[Route("[controller]")]

public class CitiesController : ControllerBase {

	// GET
	[HttpGet]
	public async Task<City> Get() {
		
	}
}