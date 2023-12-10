using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Microsoft.AspNetCore.Identity;
using TimeZone = Medicine.Entities.Enums.TimeZone;

namespace Medicine.Entities.Models.Auth
{
    public class User : IdentityUser<int>, IEntity
    {
        public DateOnly? Birthday { get; set; }
        public Sex? Sex { get; set; }
        public Language Language { get; set; } = Language.en;
        public string? Name { get; set; }
        public TimeZone TimeZone { get; set; } = TimeZone.CoordinatedUniversalTime;
        public SystemRole Role { get; set; } = SystemRole.User;
    }
}
