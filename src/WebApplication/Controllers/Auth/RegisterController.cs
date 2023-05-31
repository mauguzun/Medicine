using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Interfcases.Notification;
using Medicine.Web.UseCases.Auth.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;

namespace Medicine.WebApplication.Controllers.Auth
{
    [ApiController]
    [Route("auth/[controller]")]
    public class RegisterController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly IEmailService _emailSender;
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IUserStore<User> userStore,
            IEmailService emailSender,
            ILogger<RegisterController> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = _GetEmailStore();
            _emailSender = emailSender;
            _logger = logger;

        }


        [HttpPost]
        public async Task<IActionResult> Index([FromBody] RegisterDto loginData)
        {
            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var user = _CreateUser();

            await _userStore.SetUserNameAsync(user, loginData.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, loginData.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, loginData.Password);

            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");

                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var callbackUrl = Url.Page(
                    "/Auth/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId, code, returnUrl = Url.Content("~/") },
                    protocol: Request.Scheme);

                await _emailSender.SendEmailAsync(loginData.Email, "Confirm your email",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    return Ok("RegisterConfirmation");
                }
            }

            return new ContentResult()
            {
                StatusCode = (int)HttpStatusCode.Forbidden,
                Content = string.Join(",", result.Errors.ToList().Select(x => x.Description))
            };
        }

        private User _CreateUser()
        {
            try
            {
                return Activator.CreateInstance<User>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<User> _GetEmailStore() => !_userManager.SupportsUserEmail ?
              throw new NotSupportedException("The default UI requires a user store with email support.") :
              (IUserEmailStore<User>)_userStore;

    }
}
