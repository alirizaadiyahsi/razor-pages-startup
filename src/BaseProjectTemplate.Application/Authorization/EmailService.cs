using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BaseProjectTemplate.Application.Authorization
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // TODO: Wire this up to actual email sending logic via SendGrid, local SMTP, etc.
            return Task.CompletedTask;
        }

        public Task SendEmailConfirmationAsync(string userEmail, string callbackUrl)
        {
            return SendEmailAsync(userEmail, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>link</a>");
        }

        public Task SendResetPasswordAsync(string email, string callbackUrl)
        {
            return SendEmailAsync(email, "Reset Password",
                $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
        }
    }
}
