using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using Reactivities.Application.Common.Interfaces.Authentication;
using Reactivities.Application.Common.Interfaces.Services;
using Reactivities.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace Reactivities.Infrastructure.Authentication
{
    internal class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly JwtSettings jwtSettings;

        public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtSettings)
        {
            this.dateTimeProvider = dateTimeProvider;
            this.jwtSettings = jwtSettings.Value;
        }

        public string GenerateToken(AppUser user)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtSettings.Secret)
                    ), SecurityAlgorithms.HmacSha256
                );

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.UserName!),
                new Claim(JwtRegisteredClaimNames.Email, user.Email!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                expires: dateTimeProvider.UtcNow.AddMinutes(jwtSettings.ExpiryMinutes),
                claims: claims,
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
