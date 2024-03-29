using AutoMapper;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Models.Auth.Dto;
using Medicine.Web.UseCases.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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

                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user is not null)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    UserSettingsDto userSettings = _mapper.Map<UserSettingsDto>(user);

                    var claims = new List<Claim> { new Claim("Id", user.Id.ToString()) };

                    var jwt = new JwtSecurityToken(
                            issuer: _tokenOptions.Issuer,
                            audience: _tokenOptions.Audience,
                            claims: claims,
                            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(_tokenOptions.ExpireInMin)),
                            signingCredentials: new SigningCredentials(_tokenOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                    string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                    return Ok(new ApiResponse<(string, UserSettingsDto?)>((token, userSettings)));
                }
            }

            var response = result.IsLockedOut ? "CreatedBy Locked" : result.RequiresTwoFactor 
                ? "RequiresTwoFactor" : $"Unable to load user with email '{loginDto.Email}'";

            return Unauthorized(new ApiResponse<(string, UserSettingsDto?)>((response, null)));
        }
    }
}
