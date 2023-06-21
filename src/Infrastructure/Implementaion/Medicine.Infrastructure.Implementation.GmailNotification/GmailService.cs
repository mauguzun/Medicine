using Medicine.Infrastructure.Interfcases.Notification;

namespace Medicine.Infrastructure.Implementation.GmailNotification
{
    public class GmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}