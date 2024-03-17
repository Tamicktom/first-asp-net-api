
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
  [HttpGet]
  [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(Response))]
  [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
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