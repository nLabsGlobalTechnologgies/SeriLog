using Microsoft.AspNetCore.Mvc;

namespace Logger.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Create()
    {
        return NoContent();
    }

    [HttpGet]
    public IActionResult Update(int id, string name)
    {
        return NoContent();
    }

    [HttpGet]
    public IActionResult DeleteById(int id)
    {
        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return NoContent();
    }
}
