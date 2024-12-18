using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace OnlineStoreZaliczenie.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Nie wysyłamy e-maili, po prostu logujemy do konsoli (opcjonalnie)
            Console.WriteLine($"Fake email sent to {email} with subject {subject}");
            return Task.CompletedTask;
        }
    }
}
