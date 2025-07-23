using Microsoft.AspNetCore.Mvc;

namespace DotNetBackend.Controllers {
  [ApiController]
  [Route("api/v1/auth")]
  public class AuthController : ControllerBase {
    [HttpPost("login")]
    public IActionResult Login() => Ok("JWT token here");

    [HttpPost("register")]
    public IActionResult Register() => Ok("User registered");
  }
}
