namespace BuberDinner.Infrastructure ; 
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Common.interfaces.Authentication;
using BuberDinner.Infrastructure.services;
using BuberDinner.Application.Common.services;
 

public static class DependencyInjection{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //recherche
        services.AddScoped<IJwtTokenGenerator,JwtTokenGenerator>();
        services.AddScoped<IDateTimeProvider,DateTimeProvider>();
        return services;
    }

}