namespace Medicine.Web.UseCases.Models.Auth.Dto
{
    public record ResetPasswordDto(string Email, string Password, string Code)
    {
    }
}
