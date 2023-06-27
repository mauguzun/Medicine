using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
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
                var dbContext = context.RequestServices.GetService<AppDbContextReadOnly>();

                var role = dbContext.Roles.Where(role => role.Id ==
                dbContext.UserRoles.Where(userRoles => userRoles.UserId == dbContext.Users.Where(user => user.Email == email).FirstOrDefault().Id)
                .FirstOrDefault()
                .RoleId);

                if(role is null)
                    throw new Exception("user without role")

                identity.AddClaim(new Claim(ClaimTypes.Role, role.FirstOrDefault().Name));
                context.User.AddIdentity(identity);
            }

            return base.OnCreateAsync(context, requestExecutor, requestBuilder,
                cancellationToken);



        }
    }

}
