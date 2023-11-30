using Medicine.Entities.Enums;

namespace Medicine.Web.UseCases.Auth.Dto
{


    public record UserSettingsDto(int Id, string? Name, string Email, string PhoneNumber, SystemRole Role, Language Language, Sex Sex, DateOnly? Birthday, Entities.Enums.TimeZone TimeZone)
    {
        public UserSettingsDto() : this(0, string.Empty, string.Empty, string.Empty, SystemRole.User, Language.en, Sex.Male, default, Entities.Enums.TimeZone.CoordinatedUniversalTime)
        {
        }
    }

}
