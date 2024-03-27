using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Logger.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController(ILogger<ValuesController> logger) : ControllerBase
{
    [HttpGet]
    public IActionResult Create()
    {
        Log.Information("Starting creating");
        Log.Information("Creating is finish");
        return NoContent();
    }

    [HttpGet]
    public IActionResult Update(int id, string name)
    {
        Log.Information("Starting creating");
        Log.Information("Creating is finish");
        return NoContent();
    }



    [HttpGet]
    public IActionResult DeleteById(int id)
    {
        Log.Information("Starting creating");
        Log.Information("Creating is finish");
        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        //GetAll
        Log.Information("Starting creating");
        Log.Information("Creating is finish");

        return Ok();
    }
}
