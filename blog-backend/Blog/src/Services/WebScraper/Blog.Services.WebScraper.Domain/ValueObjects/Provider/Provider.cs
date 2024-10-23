using Blog.Services.Common.Abstractions.Kernel;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider.Exceptions;

namespace Blog.Services.WebScraper.Domain.ValueObjects.Provider;

public sealed class Provider : ValueObject
{
    public string Value { get; }

    public Provider() { }

    public Provider(string value)
    {
        var nameSupported = IsNameSupported(value);
        if (!nameSupported)
            throw new UnsupportedProviderException(value);

        Value = value;
    }

    public static implicit operator Provider(string value) =>
        value is null ? null : new Provider(value);

    public static implicit operator string(Provider value) => value?.Value;

    private static bool IsNameSupported(string code) =>
        AvailableProviderNames.AllCodes.Contains(code, StringComparer.InvariantCultureIgnoreCase);

    internal static Provider Create(string value) => new(value);
}
