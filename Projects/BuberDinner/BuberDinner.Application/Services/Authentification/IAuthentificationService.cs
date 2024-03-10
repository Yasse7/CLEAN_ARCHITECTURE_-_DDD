namespace BuberDinner.Application.Services.Authentication;

public interface IAuthentificationService{
    AuthenticationResult Register(string fname,string lname ,string email,string password ) ;
    AuthenticationResult Login(string email,string password ) ;
}