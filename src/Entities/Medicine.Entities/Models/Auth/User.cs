using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;
using Microsoft.AspNetCore.Identity;

namespace Medicine.Entities.Models.Auth
{
    public class User : IdentityUser<int>, IEntity
    {
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; } = Sex.None;

        public Language Language { get; set; } = Language.en;

        public string TimeZone { get; set; } = TimeZoneInfo.Utc.DisplayName;
    }
}
