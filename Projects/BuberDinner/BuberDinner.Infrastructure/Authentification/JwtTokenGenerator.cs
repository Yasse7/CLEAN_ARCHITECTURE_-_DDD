namespace BuberDinner.Application.Authentification;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberDinner.Common.interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    var signinCredentials = new SigningCredentials(
        new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("Super-secret-key")),
            SecurityAlgorithms.HmacSha256
        );
    
    public string GenerateToken(Guid iduser,string firstname,string lastname){
        var claims = new  [] {
            new Claim(JwtRegisteredClaimNames.Sub,iduser.ToString()), 
             new Claim(JwtRegisteredClaimNames.GivenName,firstname),   
              new Claim(JwtRegisteredClaimNames.FamilyName,lastname) ,
               new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        };
        var securityToken = new JwtSecurityToken(claims:claims,
                                                    signingCredentials:signinCredentials);
    }

}