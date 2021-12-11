using Microsoft.AspNetCore.Mvc;

namespace TownBestiaryApi.Controllers; 
[ApiController]
[Route("[controller]")]

public class BoardsController : ControllerBase {
    private List<int> _boardsId = new List<int>();

    [HttpPost("board/{id}/collect")]
    public ActionResult Post([FromRoute] int id) {
        _boardsId.Add(id);
        return Ok();
    }
}