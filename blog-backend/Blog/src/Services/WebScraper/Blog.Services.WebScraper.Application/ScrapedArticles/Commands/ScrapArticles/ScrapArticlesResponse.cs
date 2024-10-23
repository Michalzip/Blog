using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;

namespace Blog.Services.WebScraper.Application.ScrapedArticles.Commands.ScrapArticles;

public record ScrapArticlesResponse(List<ScrapeArticle> ArticlesContent);
