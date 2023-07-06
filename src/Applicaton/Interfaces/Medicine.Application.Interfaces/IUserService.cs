using Medicine.Entities.Models.Auth;

namespace Medicine.Application.Interfaces
{
    public interface IUserService
    {
        public Role? GeRole(string email);
       
    }
}
