namespace Blog.Services.WebScraper.Domain.ValueObjects.Provider.Exceptions;

public class UnsupportedProviderException:Exception
{
    public string Name { get; }
    public UnsupportedProviderException(string name) : base($"An provider with this name: '{name}' is not supported.")
    {
        Name = name;
    }
}