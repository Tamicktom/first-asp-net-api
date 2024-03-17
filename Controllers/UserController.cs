
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
  [HttpGet]
  public IActionResult Get()
  {
    var response = new Response
    {
      Name = "John",
      Age = 30
    };

    return Ok(response);
  }
}