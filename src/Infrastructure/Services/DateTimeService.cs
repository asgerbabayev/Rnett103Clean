using Application.Commons.Interfaces;

namespace Infrastructure.Services;

internal class DateTimeService : IDateTime
{
    public DateTime DateTime { get => DateTime.UtcNow; }
}
