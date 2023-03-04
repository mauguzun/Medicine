using Medicine.Entities.Enums;
using Medicine.Entities.Models.Base;

namespace Medicine.Entities.Models
{
    public class UserSettings : Entity
    {
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; } = Sex.None;

        public Language Language = Language.en;

        public string TimeZone { get; set; } = TimeZoneInfo.Utc.DisplayName;
    }
}
