using AutoMapper;
using Medicine.Application.Interfaces;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Auth.Dto;
using Medicine.Web.UseCases.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Medicine.WebApplication.Controllers.Auth
{
    [ApiController]
    [Route("auth/[controller]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly TokenSettings _tokenOptions;
        private readonly IMapper _mapper;

        public LoginController(SignInManager<User> signInManager, UserManager<User> userManager, IOptions<TokenSettings> tokenOptions, IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenOptions = tokenOptions.Value;
            _mapper = mapper;
        }

        public string Index() => "work";

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] LoginDto loginDto)
        {

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {

                User user = await _userManager.FindByEmailAsync(loginDto.Email);
                var roles = await _userManager.GetRolesAsync(user);


                TokenData tokenData = _mapper.Map<TokenData>(user);
                //tokenData.Role = 

                var claims = new List<Claim> { 
                    new Claim("TokenData",JsonSerializer.Serialize(tokenData)),
                };  

                var jwt = new JwtSecurityToken(
                        issuer: _tokenOptions.Issuer,
                        audience: _tokenOptions.Audience,
                        claims: claims,
                        expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(_tokenOptions.ExpireInMin)),
                        signingCredentials: new SigningCredentials(_tokenOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                return Ok(new ApiResponse<string>(token));
            }
            if (result.RequiresTwoFactor)
            {
                return Unauthorized(new ApiResponse<string>("RequiresTwoFactor"));
              
            }
            else if (result.IsLockedOut)
            {
                return Unauthorized(new ApiResponse<string>("User Locked"));
            }

            return Unauthorized(new ApiResponse<string>($"Unable to load user with email '{loginDto.Email}'"));
        }
    }
}
