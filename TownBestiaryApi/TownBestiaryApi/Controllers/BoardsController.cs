using Microsoft.AspNetCore.Mvc;

namespace TownBestiaryApi.Controllers; 
[ApiController]
[Route("[controller]")]

public class BoardsController : ControllerBase {

    [HttpPost("{id}/collect")]
    public ActionResult Post([FromRoute] int id) {
        return Ok();
    }
}