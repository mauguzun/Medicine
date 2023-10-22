using HotChocolate.Authorization;
using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.Auth.Dto;
using Medicine.Web.UseCases.Common;
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
    public class UserSettingsController : Controller
    {

        private readonly AppDbContext _context;

        public UserSettingsController(AppDbContext context) => _context = context;


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Index([FromBody] UserSettingsDto userSettingsDto)
        {

            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
           

            var user = await _context.Users.FindAsync(userSettingsDto.UserId);


            return Ok(new ApiResponse<UserSettingsDto>(userSettingsDto));
        }
    }
}
