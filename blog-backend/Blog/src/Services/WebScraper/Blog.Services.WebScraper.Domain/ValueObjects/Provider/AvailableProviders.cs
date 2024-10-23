using Blog.Services.WebScraper.Domain.ValueObjects.Provider.Exceptions;

namespace Blog.Services.WebScraper.Domain.ValueObjects.Provider;

public static class AvailableProviders
{
    public static readonly Provider Keeper = Provider.Create(nameof(Keeper));

    public static readonly HashSet<Provider> All = new() { Keeper };

    public static Provider GetProvider(string name)
    {
        var provider = All.SingleOrDefault(q =>
            q.Value.Equals(name, StringComparison.InvariantCultureIgnoreCase)
        );
        if (provider is null)
            throw new UnsupportedProviderException(name);
        return provider;
    }
}
