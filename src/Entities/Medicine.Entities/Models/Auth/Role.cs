using Medicine.Entities.Models.Base;
using Microsoft.AspNetCore.Identity;

namespace Medicine.Entities.Models.Auth
{
    public class Role : IdentityRole<int> , IEntity
    {
       
    }
}
