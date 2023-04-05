using Medicine.Auth;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Dto.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("auth/[controller]")]
    public class ResetPasswordController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ResetPasswordController(UserManager<User> userManager) => _userManager = userManager;


        [HttpPost]
        public async Task<IActionResult> Index([FromBody] ResetPasswordDto resetDto)
        {
            var user = await _userManager.FindByEmailAsync(resetDto.Email);
            if (user == null)
                return NotFound($"Unable to load user with email '{resetDto.Email}'.");


            var result = await _userManager.ResetPasswordAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(resetDto.Code)), resetDto.Password);
            if (result.Succeeded)
            {
                return Ok("Confirmed");
            }

            return new ContentResult()
            {
                StatusCode = (int)HttpStatusCode.Forbidden,
                Content = String.Join(",", result.Errors.ToList().Select(x => x.Description))
            };

        }
    }
}
