using Logger.ToMSSql.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Logger.ToMSSql.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController(JwtProvider jwtProvider) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public IActionResult CreateToken()
    {
        var token = jwtProvider.CreateToken();
        return Ok(token);
    }
}
