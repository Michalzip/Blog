
using Blog.Services.Common.Abstractions.Dispatcher;
using Blog.Services.Common.Abstractions.Endpoints;
using Blog.Services.WebScraper.Application.ScrapedArticles.Commands.ScrapArticles;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace Blog.Services.WebScraper.Presentation.Endpoints
{
    [Route($"{ScraperEndpoint.Url}")]
    public class GetScrapedData : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet(
                    "article-data",
                    async (ISender sender) =>
                    {
                      await  sender.Send(new ScrapArticlesCommand());
                      Console.WriteLine("Hello");
                    }
                )
                .WithTags(ScraperEndpoint.Tag)
                .WithMetadata(new HttpMethodMetadata(new[] { "GET" }));
        }
    }
}
