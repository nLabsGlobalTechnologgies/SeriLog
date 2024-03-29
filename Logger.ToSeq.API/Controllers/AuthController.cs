using Logger.ToSeq.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Logger.ToSeq.API.Controllers;
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
