using Medicine.Entities.Models.Base;
using Microsoft.AspNetCore.Identity;

namespace Medicine.Entities.Models.Auth
{
    //not metter
    public class Role : IdentityRole<int> , IEntity
    {
       
    }
}
