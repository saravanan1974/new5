using Microsoft.AspNetCore.Mvc;

namespace AarelWelcomeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome to Aarel");
    }
}
