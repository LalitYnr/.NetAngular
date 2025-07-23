using Microsoft.AspNetCore.Mvc;

namespace DotNetBackend.Controllers {
  [ApiController]
  [Route("api/v1/dashboard")]
  public class DashboardController : ControllerBase {
    [HttpGet]
    public IActionResult Get() => Ok("Dashboard data");
  }
}
