namespace KaiDns.Server.Services.Interfaces
{
    public interface IAuthorizationService
    {
        bool VerificationEmail (string username, string hash);
        bool VerificationUser (string username, string password);
    }
}
