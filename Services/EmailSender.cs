using IUBAlumniUSA.Data;
using IUBAlumniUSA.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace UBAlumniUSA.Services;

public class EmailSender : IEmailSender
{
    private readonly ILogger _logger;
    private readonly Repository _repository;

    public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor,
                       ILogger<EmailSender> logger,
                      Repository repository)
    {
        Options = optionsAccessor.Value;
        _logger = logger;
        _repository = repository;
    }

    public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        if (string.IsNullOrEmpty(Options.SendGridKey))
        {
            throw new Exception("Null SendGridKey");
        }
        await Execute(Options.SendGridKey, subject, message, toEmail);
    }

    public async Task Execute(string apiKey, string subject, string message, string toEmail)
    {
        var client = new SendGridClient(apiKey);
        var senderEmail = _repository.GetSysConfigByKey("EmailSender");
        var senderEmailName = _repository.GetSysConfigByKey("EmailSenderName");

        var from = new EmailAddress(senderEmail, senderEmailName);
        var msg = new SendGridMessage()
        {
            From = from,
            Subject = subject,
            PlainTextContent = message,
            HtmlContent = message
        };
        char[] delimiters = new[] { ',', ';', ' ' };  // List of your delimiters
        var _emails = toEmail.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        
        foreach(var _email in _emails)
        {
            msg.AddTo(new EmailAddress(_email));
        }
        
        
        // Disable click tracking.
        // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
        msg.SetClickTracking(true, true);
        var response = await client.SendEmailAsync(msg);
        _logger.LogInformation(response.IsSuccessStatusCode
                               ? $"Email to {toEmail} queued successfully!"
                               : $"Failure Email to {toEmail}");

    }
}
