namespace BuberDinner.Application.Common.services;

public interface IDateTimeProvider {
    DateTime UtcNow {get;}
}