using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models.Events;
using TownBestiaryApi.Models.Facts;
using TownBestiaryApi.Models.Home;

namespace TownBestiaryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase {
	[HttpGet]
	public ActionResult<HomeInfo> Get() {
		var homeInfo = new HomeInfo {
			Events = PartnersStorage.Events,
			Fact = FactStorage.Facts.First()
		};
		return Ok(homeInfo);
	}
}