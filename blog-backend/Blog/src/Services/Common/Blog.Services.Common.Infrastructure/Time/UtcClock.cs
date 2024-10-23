using Blog.Services.Common.Abstractions.Time;

namespace Blog.Services.Common.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDateTime() => DateTime.UtcNow;

    public DateTimeOffset CurrentDateTimeOffset() => DateTimeOffset.UtcNow;
}
