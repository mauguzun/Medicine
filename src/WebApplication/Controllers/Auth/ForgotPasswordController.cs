using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Interfcases.Notification;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;

namespace Medicine.WebApplication.Controllers.Auth
{
    [ApiController]
    [Route("auth/[controller]")]
    public class ForgotPasswordController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IEmailService _emailSender;

        public ForgotPasswordController(
            UserManager<User> userManager,
            IEmailService emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> Index(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null || !await _userManager.IsEmailConfirmedAsync(user))
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            var callbackUrl = Url.Page(
                "/Auth/ResetPassword",
                pageHandler: null,
                values: new { code },
                //values: new { area = "Identity", code },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(
                email,
                "Reset Password",
                $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            return Ok("Forgot Email Send");

        }

    }
}
