using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MarketFriend.WS.Modelo.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MarketFriend.WS.MarketFriend.Seguridad
{
    public class GenerarTokenJwt
    {
        public static IConfiguration _config;
        public GenerarTokenJwt(IConfiguration config)
        {
            _config = config;
        }
        public static MKFUsuarioReponse GenerarteTokenJwt(MKFUsuarioReponse oUsuario)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Pues aunque a primera vista pudiera parecerlo, no lo es ;"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, oUsuario.Codigo),
                new Claim(JwtRegisteredClaimNames.Sub, oUsuario.Usuario),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: "issuer",
                audience: "issuer",
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );

            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            oUsuario.TokenJwt = encodeToken;
            return oUsuario;
        }
    }
}
