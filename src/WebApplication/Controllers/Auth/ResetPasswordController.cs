using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Auth.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Net;
using System.Text;

namespace Medicine.WebApplication.Controllers.Auth
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
                Content = string.Join(",", result.Errors.ToList().Select(x => x.Description))
            };

        }
    }
}
