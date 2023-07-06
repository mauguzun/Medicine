using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using Medicine.Application.Interfaces;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Medicine.WebApplication.HttpHandler
{
    public class HttpRequestInterceptor : DefaultHttpRequestInterceptor
    {


        public override ValueTask OnCreateAsync(
            HttpContext context,
            IRequestExecutor requestExecutor,
            IQueryRequestBuilder requestBuilder,
            CancellationToken cancellationToken)
        {
            var email = context.User.FindFirstValue(ClaimTypes.Email);

            if (email is not null)
            {
                var identity = new ClaimsIdentity();
                var service = context.RequestServices.GetService<IUserService>();

                var role = service.GeRole(email);

                if (role is null)
                    throw new Exception("user without role");

                identity.AddClaim(new Claim(ClaimTypes.Role, role.Name));
                context.User.AddIdentity(identity);
            }

            return base.OnCreateAsync(context, requestExecutor, requestBuilder,
                cancellationToken);



        }
    }

}
