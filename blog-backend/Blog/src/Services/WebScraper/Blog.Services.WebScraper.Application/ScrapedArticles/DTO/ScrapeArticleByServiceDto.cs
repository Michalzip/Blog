using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;

namespace Blog.Services.WebScraper.Application.ScrapedArticles.DTO;

public record  ScrapeArticleByServiceDto
{
    public List<ScrapeArticle> ScrapedArticles { get; set; }
   
}