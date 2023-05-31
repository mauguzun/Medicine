namespace Medicine.Infrastructure.Interfcases.Notification
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}