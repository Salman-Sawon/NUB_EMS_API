using StudentWebAPI.Models;

namespace EMSAPI.Services
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, User user);
    }
}
