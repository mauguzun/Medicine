﻿using Medicine.Entities.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Net;
using System.Text;

namespace Medicine.WebApplication.Controllers.Auth
{
    [ApiController]
    [Route("auth/[controller]")]
    public class ConfirmEmailController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ConfirmEmailController(UserManager<User> userManager) => _userManager = userManager;

        public async Task<IActionResult> Index(string userId, string code)
        {

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
                var result = await _userManager.ConfirmEmailAsync(user, code);
                if (result.Succeeded)
                {
                    return Ok("Thank you for confirming your email.");
                }
                else
                {

                    return new ContentResult()
                    {
                        StatusCode = (int)HttpStatusCode.Forbidden,
                        Content = "Error confirming your email"
                    };
                }
            }
            return NotFound($"Unable to load user with ID '{userId}'.");
        }
    }
}
