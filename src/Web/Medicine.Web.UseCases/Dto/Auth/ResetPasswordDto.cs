namespace Medicine.Web.UseCases.Dto.Auth
{
    public record ResetPasswordDto(string Email, string Password, string Code)
    {
    }
}
