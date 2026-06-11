using Microsoft.AspNetCore.Mvc;

namespace BiDashboard.API.Controllers;

[ApiController]
[Route("api/reports")]
public class ReportController : ControllerBase
{
    [HttpGet("sales")]
    public IActionResult GetSalesReport()
    {
        var data = new
        {
            totalSales = 125000,
            orders = 320,
            region = "North America"
        };

        return Ok(data);
    }
}