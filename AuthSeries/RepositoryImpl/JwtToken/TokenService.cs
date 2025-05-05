using StudentWebAPI.Service;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using StudentWebAPI.Models;
using System.Text;
using EMSAPI.Services;

namespace StudentWebAPI.RepositoryImpl.JwtToken
{
    public class TokenService : ITokenService
    {
        private const double EXP_DURATION_MINUTES = 2000;

        public string BuildToken(string key, string issuer, User userModel)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, userModel.username),
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(issuer: issuer, audience: issuer, claims, expires: DateTime.Now.AddMinutes(EXP_DURATION_MINUTES), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
