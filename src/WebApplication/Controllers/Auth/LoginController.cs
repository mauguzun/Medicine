using Medicine.Auth;
using Medicine.Entities.Models.Auth;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public async Task<string> Index() => "Works";

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var result = await _signInManager.PasswordSignInAsync(email, password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {

                var claims = new List<Claim> { new Claim(ClaimTypes.Email, email)};

                var jwt = new JwtSecurityToken(
                        issuer: _tokenOptions.Issuer,
                        audience: _tokenOptions.Audience,
                        claims: claims,
                        expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(_tokenOptions.ExpireInMin)),
                        signingCredentials: new SigningCredentials(_tokenOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                //_logger.LogInformation("User logged in.");
                return Ok(token);
            }
            //if (result.RequiresTwoFactor)
            //{
            //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
            //}
            else if (result.IsLockedOut)
            {
                //_logger.LogWarning("User account locked out.");
                return new ContentResult()
                {
                    StatusCode = (int)HttpStatusCode.Forbidden,
                    Content = "User Locked"
                };
            }
            else
            {
                return new ContentResult()
                {
                    StatusCode = (int)HttpStatusCode.Forbidden,
                    Content = "User Locked"
                };

            }

        }
    }
}
