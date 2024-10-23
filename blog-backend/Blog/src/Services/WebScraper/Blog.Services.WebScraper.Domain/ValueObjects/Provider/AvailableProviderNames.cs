using Blog.Services.WebScraper.Domain.ValueObjects.Provider.Exceptions;

namespace Blog.Services.WebScraper.Domain.ValueObjects.Provider;

internal static class AvailableProviderNames
{
    internal const string Keeper = nameof(Keeper);

    internal static readonly IReadOnlyCollection<string> AllCodes = new List<string> { Keeper };
}
