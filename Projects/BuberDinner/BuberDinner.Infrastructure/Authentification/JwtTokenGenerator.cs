namespace BuberDinner.Infrastructure.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberDinner.Common.interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;


public class JwtTokenGenerator : IJwtTokenGenerator
{
   
    public string GenerateToken(Guid iduser,string firstname,string lastname){
         var signinCredentials = new SigningCredentials(
        new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("Super-secret-key-for-my-token-token")),
            SecurityAlgorithms.HmacSha256
        );
    
        var claims = new  [] {
            new Claim(JwtRegisteredClaimNames.Sub,iduser.ToString()), 
             new Claim(JwtRegisteredClaimNames.GivenName,firstname),   
              new Claim(JwtRegisteredClaimNames.FamilyName,lastname) ,
               new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        };
        var securityToken = new JwtSecurityToken(   issuer:"buberdinner",
                                                    expires:DateTime.Now.AddDays(1),
                                                    claims:claims,
                                                    signingCredentials:signinCredentials);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

}