using Medicine.Auth;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Dto.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("auth/[controller]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly TokenSettings _tokenOptions;

        public LoginController(SignInManager<User> signInManager, IOptions<TokenSettings> tokenOptions)
        {
            _signInManager = signInManager;
            _tokenOptions = tokenOptions.Value;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] LoginDto loginDto)
        {

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {

                var claims = new List<Claim> { new Claim(ClaimTypes.Email, loginDto.Email) };

                var jwt = new JwtSecurityToken(
                        issuer: _tokenOptions.Issuer,
                        audience: _tokenOptions.Audience,
                        claims: claims,
                        expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(_tokenOptions.ExpireInMin)),
                        signingCredentials: new SigningCredentials(_tokenOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                return Ok(token);
            }
            if (result.RequiresTwoFactor)
            {
                return new ContentResult()
                {
                    StatusCode = (int)HttpStatusCode.Forbidden,
                    Content = "RequiresTwoFactor"
                };
            }
            else if (result.IsLockedOut)
            {
                return new ContentResult()
                {
                    StatusCode = (int)HttpStatusCode.Forbidden,
                    Content = "User Locked"
                };
            }

            return NotFound($"Unable to load user with email '{loginDto.Email}'.");

        }
    }
}
