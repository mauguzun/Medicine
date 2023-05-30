using Medicine.Notifications.Interfaces;

namespace Medicine.Implementation.GmailNotification
{
    public class GmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}