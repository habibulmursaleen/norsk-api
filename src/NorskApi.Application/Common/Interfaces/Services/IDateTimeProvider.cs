namespace NorskApi.Application.Common.Interfaces.Services;

public interface IDateTimeProvider
{
    DateTime Now { get; }
}