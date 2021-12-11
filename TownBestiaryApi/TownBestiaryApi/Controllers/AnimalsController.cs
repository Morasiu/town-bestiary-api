using Microsoft.AspNetCore.Mvc;

namespace TownBestiaryApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase {
    [HttpPost("adoption")]
    public ActionResult PostAdoption() {
        return Ok();
    }
}