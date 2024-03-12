using BuberDinner.Application.Common.services;
namespace BuberDinner.Infrastructure.services;

public class DateTimeProvider : IDateTimeProvider{
    public DateTime UtcNow=>DateTime.UtcNow;
    
} 