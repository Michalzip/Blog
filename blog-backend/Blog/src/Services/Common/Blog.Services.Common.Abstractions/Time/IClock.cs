namespace Blog.Services.Common.Abstractions.Time;

public interface IClock
{
    DateTime CurrentDateTime();
    DateTimeOffset CurrentDateTimeOffset();
}
