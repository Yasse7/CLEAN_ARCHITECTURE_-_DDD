namespace BuberDinner.Application.Services.Authentication;
using BuberDinner.Common.interfaces.Authentication;

public class AuthentificationService : IAuthentificationService {
    private readonly IJwtTokenGenerator _IJwtTokenGenerator;

    public AuthentificationService(IJwtTokenGenerator jwtTokenGenerator){
        this._IJwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Register(string fname,string lname ,string email,string password){

     //   checked if the user already exist 
     // create user 
     //create JWT token 
    Guid idUser = new Guid();
     var token = _IJwtTokenGenerator.GenerateToken(idUser,fname,lname);

        return new AuthenticationResult(
                    Guid.NewGuid(),
                    fname,
                    lname,
                    email,
                    token
        );


    }
     public AuthenticationResult Login(string email,string password){
        return new AuthenticationResult(     
                   Guid.NewGuid(),
                    "fname",
                    "lname",
                    email,
                    "Token"

        );


    }
}