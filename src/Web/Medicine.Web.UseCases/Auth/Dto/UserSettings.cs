using Medicine.Entities.Enums;

namespace Medicine.Web.UseCases.Auth.Dto
{

    public record  UserSettingsDto (int UserId, Language Language, string Name , Entities.Enums.TimeZone TimeZone , Sex Sex , DateOnly Birthday , string PhoneNumber)
    {
    }

}
