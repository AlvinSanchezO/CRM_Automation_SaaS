using CRM.Application.Interfaces;
using CRM.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers;

[ApiController] // <-- ¡ESTE ES EL MÁS IMPORTANTE!
[Route("api/v1/[controller]")] // Define la URL: api/v1/auth
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")] // <-- Swagger necesita saber que es un POST
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var result = await _authService.RegisterAsync(request);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var result = await _authService.LoginAsync(request);
        return Ok(result);
    }
}