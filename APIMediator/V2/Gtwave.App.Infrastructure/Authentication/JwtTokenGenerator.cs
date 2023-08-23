using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Gtwave.App.Application.Authentication.Common.Interfaces.Authentication;
using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Infrastructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly InfraestructureSettings _infraestructureSettings;
        //public JwtTokenGenerator(IOptions<InfraestructureSettings> settings)
        public JwtTokenGenerator(IOptions<InfraestructureSettings> settings) 
        {  
            _infraestructureSettings = settings.Value;
        } 
        public string GenerateToken(Usuario usuario)
        {
            var siginingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_infraestructureSettings.Secret)), 
                SecurityAlgorithms.HmacSha256);
                
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, $"{usuario.Nome} {usuario.CnsCartorio}"),
                new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.FamilyName, usuario.CnsCartorio),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken( 
                issuer: _infraestructureSettings.Issuer,
                audience: _infraestructureSettings.Audience,
                expires: DateTime.UtcNow.AddMinutes(_infraestructureSettings.TokenTimeoutMin),
                claims:claims,
                signingCredentials: siginingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken); 
        }
    }
}
