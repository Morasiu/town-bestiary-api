using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Extensions;
using TownBestiaryApi.Models.Facts;

namespace TownBestiaryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FactsController : ControllerBase {
	[HttpGet]
	public ActionResult<Fact> Get() {
		return Ok(FactStorage.Facts.Random());
	}
}