namespace Medicine.Web.UseCases.Auth.Dto
{
    public record ResetPasswordDto(string Email, string Password, string Code)
    {
    }
}
