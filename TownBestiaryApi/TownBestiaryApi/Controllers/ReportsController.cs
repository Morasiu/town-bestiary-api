using Microsoft.AspNetCore.Mvc;
using TownBestiaryApi.Models.Reports;

namespace TownBestiaryApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class ReportsController : ControllerBase {

    [HttpPost]
    public ActionResult Post(Report report) {
        ReportStorage.Reports.Add(report);
        return Ok();
    }
}