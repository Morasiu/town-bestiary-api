using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Reports;

namespace TownBestiaryApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase {
    [HttpGet("{id}")]
    public ActionResult<User> GetById([FromRoute] int id) {
        var user = new User {
            Id = 1,
            UserName = "CrazyHedgehog77",
            Reports = new List<Report> {
                new Report {
                    Id = 1,
                    Date = DateTime.Now.AddDays(-7),
                    Type = ReportType.InjuredAnimal,
                    Localization = "Zagórze 9",
                    Message = "Ranna sarna leży w rowie przy drodze"
                },
                new Report {
                    Id = 2,
                    Date = DateTime.Now.AddDays(-20),
                    Type = ReportType.DangerousAnimal,
                    Localization = "Liściasta 8",
                    Message = "Stado dzików przy śmietniku"
                }
            },
            // TODO
            // CollectedBoards = 
        };
        return user;
    }
}