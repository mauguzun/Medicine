using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.DataLoaders.DataLoader;
using Medicine.Web.UseCases.Models.GraphqlResponse.Users;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.Queries.Reminders
{
    [ExtendObjectType(nameof(Queries))]
    public class UserQuery 
    {

        [UseProjection]
        [UseSorting()]
        [UseFiltering()]
        public async Task<IEnumerable<UserResponse>> UserFind(
            IResponseLoader<int, User, UserResponse> dataLoader)
        {
            var users = await dataLoader.LoadAsync();
            return users;
        }

    }

}