namespace KaiDns.Server.Services.Interfaces
{
    public interface IAuthorizationService
    {
        bool SendEmail (string message, string from, string to);
    }
}
