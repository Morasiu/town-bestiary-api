using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models.Boards;
using TownBestiaryApi.Models.Users;

namespace TownBestiaryApi.Controllers; 
[ApiController]
[Route("[controller]")]

public class BoardsController : ControllerBase {

    [HttpPost("{id}/collect")]
    public ActionResult Post([FromRoute] int id) {
        var board = BoardsStorage.Boards.SingleOrDefault(a => a.Id == id);
        if (board is null) return NotFound();
        UserStorage.User.CollectedBoards.Add(board);
        return Ok();
    }
}