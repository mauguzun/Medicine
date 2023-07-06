using Medicine.Application.Interfaces;
using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Interfcases.DataAccess;

namespace Medicine.Application.Implementation
{
    public class UserService : IUserService

    {
        private readonly IAppDbContextReadonly _appDbContextReadOnly;

        public UserService(IAppDbContextReadonly appDbContextReadOnly)
        {
            _appDbContextReadOnly = appDbContextReadOnly;
        }

        public Role? GeRole(string email)
        {
            var role = _appDbContextReadOnly.Roles.Where(role => role.Id ==
            _appDbContextReadOnly.UserRoles.Where(userRoles => userRoles.UserId == _appDbContextReadOnly.Users.Where(user => user.Email == email).FirstOrDefault().Id)
            .FirstOrDefault()
            .RoleId)
                .FirstOrDefault();

            return role;

        }
    }
}
