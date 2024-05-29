using KaiDns.Server.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace KaiDns.Server.Services
{
    public class AuthorizationService: IAuthorizationService
    {
        public string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            
            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public bool SendEmail(string message, string from, string to)
        {
            throw new NotImplementedException();
        }

        public bool VerificationEmail(string username, string hash)
        {
            throw new NotImplementedException();
        }

        public bool VerificationUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
