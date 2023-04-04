using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Medicine.Auth
{
    public class TokenSettings
    {
        public int ExpireInMin { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public string? Key { get; set; }


        public  SymmetricSecurityKey GetSymmetricSecurityKey() =>
         new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
    }

}
