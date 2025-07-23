using Microsoft.AspNetCore.Mvc;

namespace DotNetBackend.Controllers {
  [ApiController]
  [Route("api/v1/products")]
  public class ProductController : ControllerBase {
    [HttpGet]
    public IActionResult GetAll() => Ok(new[] { "Product1", "Product2" });

    [HttpPost]
    public IActionResult Create([FromBody] object product) => Ok("Product created");
  }
}
