using ApiMiniSistema.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiMiniSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public AuthController(IConfiguration configuration) 
        {
        this.configuration = configuration;
        }

        private async Task<RespuestaAutenticacionDTO> ConstruirToken(CredencialesUsuarioDTO identityUser)
        {
            var claims = new List<Claim>
            {
                new Claim("user", identityUser.UserName),
                new Claim("ejemplo segundo valor ", "valor 1111")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["KeyJwt"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(1);
            var tokenSecurity = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: creds);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenSecurity);

            return new RespuestaAutenticacionDTO
            { 
                Token = token,
                Expiracion = expiration
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacionDTO>>Login([FromBody] CredencialesUsuarioDTO credencialesUsuarioDTO)
        {
            try
            {
                if (credencialesUsuarioDTO.UserName == configuration["UserAdmin"] && credencialesUsuarioDTO.Password == configuration["PasswordAdmin"])
                {
                    return await ConstruirToken(credencialesUsuarioDTO);
                }
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
