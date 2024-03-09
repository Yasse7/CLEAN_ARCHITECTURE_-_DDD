namespace BuberDinner.Contracts.Authentication ; 

public record AuthentificatinRespone(
    Guid Id,
    string FirstName ,
    string LastName , 
    string Email ,
    string token

);