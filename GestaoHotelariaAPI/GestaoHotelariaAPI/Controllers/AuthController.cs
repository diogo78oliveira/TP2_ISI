using Dapper;
using GestaoHotelariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IDbConnection _dbConnection;
    private readonly IConfiguration _configuration;

    public AuthController(IDbConnection dbConnection, IConfiguration configuration)
    {
        _dbConnection = dbConnection;
        _configuration = configuration;
    }

    /// <summary>
    /// Realiza o login do utilizador e retorna um token.
    /// </summary>
    /// <param name="request">Objeto de solicitação com email e password do utilizador.</param>
    /// <returns>Token JWT para autenticação.</returns>
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new { message = "Email e Password são obrigatórios." });
        }

        var query = @"
            SELECT UtilizadorID, Email, Password, Perfil 
            FROM Utilizadores 
            WHERE Email = @Email";

        var user = await _dbConnection.QueryFirstOrDefaultAsync<Utilizador>(query, new { Email = request.Email });

        if (user == null || user.Password != request.Password)
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

    /// <summary>
    /// Gera um token JWT para o utilizador autenticado.
    /// </summary>
    /// <param name="user">Utilizador autenticado.</param>
    /// <returns>Token JWT gerado.</returns>
    private string GenerateJwtToken(Utilizador user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.UtilizadorID.ToString()),
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.Role, user.Perfil)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
