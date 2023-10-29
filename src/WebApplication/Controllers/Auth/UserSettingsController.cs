using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Web.UseCases.Auth.Dto;
using Medicine.Web.UseCases.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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
            bool response = userSettingsDto.Id.ToString() == User.Claims.Where(x => x.Type == "Id").First().Value;
            if (response)
            {
                var user = await _context.Users.FindAsync(userSettingsDto.Id);

                user.Language = userSettingsDto.Language;
                user.PhoneNumber = userSettingsDto.PhoneNumber;
                user.Sex = userSettingsDto.Sex;
                user.Language = userSettingsDto.Language;
                user.Birthday = userSettingsDto.Birthday;
                user.TimeZone = userSettingsDto.TimeZone; 
                user.Name = userSettingsDto.Name;

                _context.Users.Update(user);

                _context.SaveChagesAsync();
            }

            return Ok(new ApiResponse<bool>(response));
        }
    }
}
