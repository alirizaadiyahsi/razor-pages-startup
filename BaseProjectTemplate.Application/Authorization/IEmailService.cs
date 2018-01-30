using System.Threading.Tasks;

namespace BaseProjectTemplate.Application.Authorization
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);

        Task SendEmailConfirmationAsync(string userEmail, string callbackUrl);
    }
}