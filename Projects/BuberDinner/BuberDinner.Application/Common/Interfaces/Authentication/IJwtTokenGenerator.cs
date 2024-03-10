namespace BuberDinner.Common.interfaces.Authentication;

public interface IJwtTokenGenerator
 {
    string GenerateToken(Guid UserId,string firstname,string lastname);
}