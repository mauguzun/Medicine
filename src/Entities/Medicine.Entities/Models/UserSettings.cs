using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class UserSettings : Entity
    {
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }

        public Language Language = Language.enUs;
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Utc;
    }
}
