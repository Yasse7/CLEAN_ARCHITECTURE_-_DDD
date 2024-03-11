namespace BuberDinner.Infrastructure ; 
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Common.interfaces.Authentication;
 

public static class DependencyInjection{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IJwtTokenGenerator,JwtTokenGenerator>();
        return services;
    }

}