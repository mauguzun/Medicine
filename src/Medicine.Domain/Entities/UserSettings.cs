using Medicine.Domain.Entities.Base;
using Medicine.Domain.Enums;

namespace Medicine.Domain.Entities
{
    public class UserSettings : Entity
    {
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }

        public Language Language = Language.enUs;
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Utc;
    }
}
