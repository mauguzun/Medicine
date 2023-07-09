using Medicine.Application.Interfaces;
using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Interfcases.DataAccess;

namespace Medicine.Application.Implementation
{
    public class UserService : IUserService
    {
        private readonly IAppDbContextReadonly _appDbContextReadOnly;
        private User _user;

        public UserService(IAppDbContextReadonly appDbContextReadOnly)
        {
            _appDbContextReadOnly = appDbContextReadOnly;
        }

        public User? GetUserByEmail(string email)
        {
            _user = _user ?? _appDbContextReadOnly.Users.Where(user => user.Email == email).FirstOrDefault();
            return _user;
        }
        public User? GetUserById(int id)
        {
            _user = _user ?? _appDbContextReadOnly.Users.Where(user => user.Id == id).FirstOrDefault();
            return _user;
        }

        public Role? GeRole(string email)
        {
            var role = _appDbContextReadOnly.Roles.Where(role => role.Id ==
            _appDbContextReadOnly.UserRoles.Where(userRoles => userRoles.UserId == GetUserByEmail(email).Id).FirstOrDefault().RoleId)
                .FirstOrDefault();

            return role;

        }

    
    }
}
