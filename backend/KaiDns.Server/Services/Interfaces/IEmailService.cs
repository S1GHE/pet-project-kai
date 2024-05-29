namespace KaiDns.Server.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail (string message, string from, string to);
    }
}
