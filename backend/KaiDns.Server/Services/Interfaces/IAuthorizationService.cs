namespace KaiDns.Server.Services.Interfaces
{
    public interface IAuthorizationService
    {
        string CreateMD5Hash(string input);
        bool VerificationEmail (string username, string hash);
        bool VerificationUser (string username, string password);
    }

}
