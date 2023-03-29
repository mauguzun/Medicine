using Medicine.Notifications.Interfaces;

namespace Medicine.Notification.Imlemenation
{
    public class GmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Console.WriteLine(email);
            Console.WriteLine(subject);
            Console.WriteLine(htmlMessage);
            return Task.CompletedTask;
        }
    }
}