using System.Threading.Tasks;

namespace BusinessLogic.EmailSender
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}