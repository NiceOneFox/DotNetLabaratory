using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace BusinessLogic.EmailSender
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;

        private readonly EmailSettings _emailSettings;
        public EmailService(ILogger<EmailService> logger, IOptions<EmailSettings> emailSettings)
        {
            _logger = logger;
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            _logger.LogTrace("SendEmailAsync entry point");
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(_emailSettings.Name, _emailSettings.EmailId));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            _logger.LogDebug("Created email:" + emailMessage.TextBody, emailMessage.From, emailMessage.To);

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_emailSettings.Host, _emailSettings.Port, _emailSettings.UseSSL);
                await client.AuthenticateAsync(_emailSettings.EmailId, _emailSettings.Password);
                await client.SendAsync(emailMessage);

                _logger.LogInformation("Email sent:" + emailMessage);

                await client.DisconnectAsync(true);
            }
      
        }
    }

}
