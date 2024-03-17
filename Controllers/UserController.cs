
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
  [HttpGet]
  [Route("{id:int}")]
  [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(Response))]
  [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
  public IActionResult Get(int id, string name, int age)
  {
    var response = new Response
    {
      Id = id,
      Name = name,
      Age = age
    };

    return Ok(response);
  }
}