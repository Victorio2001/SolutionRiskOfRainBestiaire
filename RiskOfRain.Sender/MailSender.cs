using RiskOfRain.Sender.Interfaces;

namespace RiskOfRain.Sender;

public class MailSender: IMailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        return Task.FromResult(0);
    }
}