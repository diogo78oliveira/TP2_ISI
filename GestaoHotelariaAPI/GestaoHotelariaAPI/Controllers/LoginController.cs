using GestaoHotelariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly GestaoHotelariaContext _context;

    public AuthController(GestaoHotelariaContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new { message = "Email e Password são obrigatórios." });
        }

        var user = await _context.Utilizadores
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (user == null)
            return Unauthorized(new { message = "Email ou password incorretos." });

        if (user.Password != request.Password)
            return Unauthorized(new { message = "Email ou password incorretos." });

        if (user.Perfil != "gestor")
            return Forbid("Acesso permitido apenas para gestores.");

        var token = GenerateJwtToken(user);

        return Ok(new LoginResponse
        {
            Token = token,
            Perfil = user.Perfil
        });
    }

    private string GenerateJwtToken(Utilizador user)
    {
        var token = "fake-jwt-token"; 
        return token;
    }
}
