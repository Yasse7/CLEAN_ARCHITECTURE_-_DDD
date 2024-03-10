namespace BuberDinner.Application ; 
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Services.Authentication;

public static class DependencyInjection{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthentificationService, AuthentificationService>(); 
        return services;
    }

}