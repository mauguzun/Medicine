using Medicine.Entities.Enums;

namespace Medicine.Web.UseCases.Auth.Dto
{
    public record  UserSettingsDto (int Id, Language Language, string Name , string TimeZone , Sex Sex , DateOnly Date , string PhoneNumber)
    {
    }

}
