using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Medicine.Auth
{
    public class AuthOptions
    {
        public const int EXPIERSINMIN = 5;
        public const string ISSUER = "MyAuthServer"; 
        public const string AUDIENCE = "MyAuthClient"; 
        const string KEY = "mysupersecret_secretkey!123";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }

    public class HttpRequestInterceptor : DefaultHttpRequestInterceptor
    {
        public override ValueTask OnCreateAsync(
            HttpContext context,
            IRequestExecutor requestExecutor, 
            IQueryRequestBuilder requestBuilder,
            CancellationToken cancellationToken)
        {
            var identity = new ClaimsIdentity();
            var email  = context.User.FindFirstValue(ClaimTypes.Email);

            if(email is not null)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, SystemRole.User.ToString()));
                context.User.AddIdentity(identity);
            }


            return base.OnCreateAsync(context, requestExecutor, requestBuilder,
                cancellationToken);

        }
    }

}
