using System.Net;
using System.Net.Mail;
using System.Text;
using KaiDns.Server.Services.Interfaces;

namespace KaiDns.Server.Services
{
    public class EmailService:IEmailService
    {
        public bool SendEmail(string subject, string from, string toEmail)
        {
            // Set up SMTP client
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("kaidns2024@gmail.com", "A8[r7HGz!cxt");

            // Create email message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("kaidns2024@gmail.com");
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendFormat("<h1>User Registered</h1>");
            mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>Thank you For Registering account</p>");
            mailMessage.Body = mailBody.ToString();

            // Send email
            client.Send(mailMessage);
            return true;
        }
    }
}
