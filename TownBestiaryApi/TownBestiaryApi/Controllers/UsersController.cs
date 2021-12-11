using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Reports;
using TownBestiaryApi.Models.Users;

namespace TownBestiaryApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase {
    [HttpGet("{id}")]
    public ActionResult<User> GetById([FromRoute] int id) {
        return UserStorage.User;
    }
}