using Microsoft.AspNetCore.Mvc;
namespace BuberDinner.Api.Controllers;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase{
    private readonly IAuthentificationService _IAuthentificationService;
    public AuthenticationController(IAuthentificationService AuthentificationService){
        this._IAuthentificationService = AuthentificationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegistrationRequest request){
       var authresult =  _IAuthentificationService.Register(
             request.FirstName,
             request.LastName,
             request.Email,
             request.Password);

        var response = new AuthentificatinRespone(
             authresult.Id,
             authresult.FirstName,
             authresult.LastName,
             authresult.Email,
              authresult.Token
             );
        

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authresult =  _IAuthentificationService.Login(
             request.Email,
             request.Password);

        var response = new AuthentificatinRespone(
             authresult.Id,
             authresult.FirstName,
             authresult.LastName,
             authresult.Email,
              authresult.Token
             );
        

        return Ok(response);
    }

}