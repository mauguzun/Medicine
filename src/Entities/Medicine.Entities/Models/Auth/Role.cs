using Medicine.Entities.Models.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Entities.Models.Auth
{
    public class Role : IdentityRole<int> , IEntity
    {
       
    }
}
