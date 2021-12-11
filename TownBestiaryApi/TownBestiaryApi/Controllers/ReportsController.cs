using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models.Reports;

namespace TownBestiaryApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class ReportsController : ControllerBase {
    private List<Report> _reports = new List<Report>();

    [HttpPost]
    public ActionResult Post(Report report) {
        _reports.Add(report);
        return Ok();
    }
}